using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        // Поля класу
        int N = 1;
        int i = 0, j = 0;
        int Change;
        double[,] A = new double[6, 6];
        double[] B = new double[6];
        double[] X = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X_vector_dgv.ReadOnly = true;
            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            C_matrix_dgv.AllowUserToAddRows = false;

            NUD_rozmir.Value = 1;
            A_matrix_dgv.ColumnCount = 1;
            A_matrix_dgv.RowCount = 1;
            C_matrix_dgv.ColumnCount = 1;
            C_matrix_dgv.RowCount = 1;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = 1;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = 1;

            A_matrix_dgv.RowHeadersVisible = false;
            A_matrix_dgv.ColumnHeadersVisible = false;
            B_vector_dgv.RowHeadersVisible = false;
            B_vector_dgv.ColumnHeadersVisible = false;
            C_matrix_dgv.RowHeadersVisible = false;
            C_matrix_dgv.ColumnHeadersVisible = false;
            X_vector_dgv.RowHeadersVisible = false;
            X_vector_dgv.ColumnHeadersVisible = false;

            CB_Method.SelectedIndex = 0;
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt32(NUD_rozmir.Value);
            A_matrix_dgv.ColumnCount = N;
            A_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;
            C_matrix_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
            X_vector_dgv.RowCount = N;
        }

        private void Decomp(int N, ref int Change)
        {
            double[,] L = new double[N + 1, N + 1];
            double[,] U = new double[N + 1, N + 1];

            for (int k = 1; k <= N; k++)
            {
                L[k, k] = 1.0;

                for (int j = k; j <= N; j++)
                {
                    double sum = 0.0;
                    for (int m = 1; m <= k - 1; m++)
                        sum += L[k, m] * U[m, j];
                    U[k, j] = A[k, j] - sum;
                }

                for (int i = k + 1; i <= N; i++)
                {
                    double sum = 0.0;
                    for (int m = 1; m <= k - 1; m++)
                        sum += L[i, m] * U[m, k];

                    if (Math.Abs(U[k, k]) < 1e-12)
                    {
                        MessageBox.Show($"U[{k},{k}] ≈ 0 — матриця сингулярна. LU-розклад неможливий.");
                        return;
                    }
                    L[i, k] = (A[i, k] - sum) / U[k, k];
                }
            }

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (i > j)
                        C_matrix_dgv[j - 1, i - 1].Value = L[i, j].ToString("G8");
                    else
                        C_matrix_dgv[j - 1, i - 1].Value = U[i, j].ToString("G8");

                    A[i, j] = (i > j) ? L[i, j] : U[i, j];
                }
            }
        }

        private void Solve(int Change, int N)
        {
            double[] y = new double[N + 1];

            for (i = 1; i <= N; i++)
            {
                double sum = 0.0;
                for (j = 1; j <= i - 1; j++)
                    sum += A[i, j] * y[j];
                y[i] = B[i] - sum;
            }

            for (i = N; i >= 1; i--)
            {
                double sum = 0.0;
                for (j = i + 1; j <= N; j++)
                    sum += A[i, j] * X[j];
                double diag = A[i, i];
                if (Math.Abs(diag) < 1e-12)
                {
                    MessageBox.Show($"U[{i},{i}] ≈ 0, неможливо обчислити (ділення на нуль)");
                    return;
                }
                X[i] = (y[i] - sum) / diag;
            }

            UpdateXGrid();
        }

        private void SolveGauss(int N)
        {
            double[,] a = new double[N, N + 1];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    a[i, j] = A[i + 1, j + 1];
                a[i, N] = B[i + 1];
            }

            for (int k = 0; k < N; k++)
            {
                int maxRow = k;
                for (int i = k + 1; i < N; i++)
                    if (Math.Abs(a[i, k]) > Math.Abs(a[maxRow, k]))
                        maxRow = i;

                for (int j = 0; j <= N; j++)
                {
                    double tmp = a[k, j];
                    a[k, j] = a[maxRow, j];
                    a[maxRow, j] = tmp;
                }

                if (Math.Abs(a[k, k]) < 1e-12)
                {
                    MessageBox.Show($"a[{k + 1},{k + 1}] ≈ 0 — система вироджена");
                    return;
                }

                double diag = a[k, k];
                for (int j = k; j <= N; j++)
                    a[k, j] /= diag;

                for (int i = k + 1; i < N; i++)
                {
                    double factor = a[i, k];
                    for (int j = k; j <= N; j++)
                        a[i, j] -= factor * a[k, j];
                }
            }

            for (int i = N - 1; i >= 0; i--)
            {
                X[i + 1] = a[i, N];
                for (int j = i + 1; j < N; j++)
                    X[i + 1] -= a[i, j] * X[j + 1];
            }

            UpdateXGrid();
        }

        private void UpdateXGrid()
        {
            for (i = 1; i <= N; i++)
                X_vector_dgv[0, i - 1].Value = X[i].ToString("G8");
        }

        private void BCreateGrid_Click(object sender, EventArgs e)
        {
            bool errA = false, errB = false;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    try
                    {
                        object v = A_matrix_dgv[j - 1, i - 1].Value;
                        if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                            throw new Exception("Порожня клітинка");

                        A[i, j] = Convert.ToDouble(v);
                        A_matrix_dgv[j - 1, i - 1].Style.BackColor = Color.White;
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Black;
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.BackColor = Color.LightCoral;
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.DarkRed;
                        errA = true;
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                try
                {
                    object v = B_vector_dgv[0, i - 1].Value;
                    if (v == null || string.IsNullOrWhiteSpace(v.ToString()))
                        throw new Exception("Порожня клітинка");

                    B[i] = Convert.ToDouble(v);
                    B_vector_dgv[0, i - 1].Style.BackColor = Color.White;
                    B_vector_dgv[0, i - 1].Style.ForeColor = Color.Black;
                }
                catch
                {
                    B_vector_dgv[0, i - 1].Style.BackColor = Color.LightCoral;
                    B_vector_dgv[0, i - 1].Style.ForeColor = Color.DarkRed;
                    errB = true;
                }
            }

            if (errA || errB)
            {
                MessageBox.Show("Помилка введення! Клітинки з помилками позначені червоним.",
                               "Помилка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (CB_Method.SelectedIndex == 0)
                {
                    Decomp(N, ref Change);
                    Solve(Change, N);
                }
                else if (CB_Method.SelectedIndex == 1)
                {
                    SolveGauss(N);
                }

                MessageBox.Show("Розв'язок знайдено успішно!",
                               "Успіх",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при розв'язанні системи:\n{ex.Message}",
                               "Помилка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }
                B_vector_dgv[0, i].Value = "";
                X_vector_dgv[0, i].Value = "";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                A_matrix_dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                A_matrix_dgv[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }

        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                B_vector_dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                B_vector_dgv[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }
    }
}
