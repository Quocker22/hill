using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp2
{
    class HillCipher
    {
        public string enCode(string args, string b, int[] o)
        {
            int l = 0;
            int[,] c = new int[100, 100];
            int[,] d = new int[100, 100];

            char[] e = new char[100];
            int[] f = new int[100];
            int[] g = new int[100];
            char[] h = new char[100];
            int n = Convert.ToInt32(b);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = o[l];
                    l++;
                }
            }

            int det = dinhthuc(a, n);
            if (det == 0 || USCLN(det, 26) != 1)
            {
                MessageBox.Show("key không hợp lệ vui lòng nhập lai");
                return "";
            }

            int so;
            if (det > 0)
            {
                so = timso(det);

            }
            else
            {
                so = timsoam(det);
            }
            matranphu(a, c, n);
            matranphuz26(c, d, n, so);

            int m = args.Length;
            docfile(e, args, m);
           

            chuyensangmangso(e, f, m);
            
            mahoa(a, f, g, h, m, n);
            string kt ="";
            for(int i = 0; i < m; i++)
            {
                kt += h[i];
            }
            
            return kt;
        }

        public string deCode(string args, string b, int[] o)
        {
            int l = 0;
            int[,] c = new int[100, 100];
            int[,] d = new int[100, 100];

            char[] e = new char[100];
            int[] f = new int[100];
            int[] g = new int[100];
            char[] h = new char[100];
            int n = Convert.ToInt32(b);
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = o[l];
                    l++;
                }
            }
            int det = dinhthuc(a, n);
            
            int so;
            if (det > 0)
            {
                so = timso(det);

            }
            else
            {
                so = timsoam(det);
            }
            matranphu(a, c, n);
            matranphuz26(c, d, n, so);
            int m = args.Length;
            docfile(e, args, m);
            chuyensangmangso(e, f, m);
            giaima(d, f, g, h, m, n);
            string kt = "";
            for (int i = 0; i < m; i++)
            {
                kt += h[i];
            }
            return kt;
        }
        public int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        public int dinhthuc(int[,] a, int k)
        {
            int[,] b = new int[100, 100];
            int s = 1, det = 0;
            int i, j, m, n, c;
            if (k == 1)
            {
                return (a[0,0]);
            }
            else
            {
                det = 0;
                for (c = 0; c < k; c++)
                {
                    m = 0;
                    n = 0;
                    for (i = 0; i < k; i++)
                    {
                        for (j = 0; j < k; j++)
                        {
                            b[i,j] = 0;
                            if (i != 0 && j != c)
                            {
                                b[m,n] = a[i,j];
                                if (n < (k - 2))
                                    n++;
                                else
                                {
                                    n = 0;
                                    m++;
                                }
                            }
                        }
                    }
                    det = det + s * (a[0,c] * dinhthuc(b, k - 1));
                    s = -1 * s;
                }
            }

            return (det);
        }

        private int timso(int det)
        {
            int i = 1;
            while (true)
            {
                if ((i * det) % 26 == 1)
                {
                    return i;
                }
                i++;
            }
        }

        private int timsoam(int det)
        {
            int a = det * (-1);
            int i = 1;
            while (true)
            {
                if ((i * a) % 26 == 25)
                {
                    return i;
                }
                i++;

            }

        }

        private void matranphu(int[,] a,int[,] c, int n)// tạo ma trận phụ
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = n;
                    int[,] b = new int[100, 100] ;
                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {

                            b[k,l] = a[k,l];
                        }

                    }
                    xoahangcot(b, ref x, j, i);
                    if ((i + j) % 2 == 0)
                    {

                        c[i,j] = dinhthuc(b, n - 1);
                    }
                    else
                    {
                        c[i,j] = -dinhthuc(b, n - 1);
                    }
                }

            }
        }

        private void xoahangcot(int[,] a, ref int n, int dong, int cot)// xoá hang  va cot tương ứng
        {
            for (int i = dong; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = a[i + 1,j];
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = cot; j < n; j++)
                {
                    a[i,j] = a[i,j + 1];
                }
            }
            n--;
        }

        private void matranphuz26(int[,] c, int[,] d, int n, int so) // tạo ma trận nghịch đảo trên modu
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (c[i,j] >= 0)
                    {
                        d[i,j] = (((c[i,j]) % 26) * so) % 26;
                    }
                    else
                    {
                        int x = 26 - ((c[i,j] * (-1)) % 26);
                        d[i,j] = (x * so) % 26;
                    }
                }
            }
        }

        private void docfile(char[] e, string file, int m)
        {
                for (int i = 0; i < m; i++)
                {
                    e[i] = file[i];
                }
                e[m] = '\0';
        }

        private void chuyensangmangso(char[] e, int[] f, int m)// chuyen ky tu sang so de xu ly.
        {
            for (int i = 0; i < m; i++)
            {
                int x = e[i] - 97;
                f[i] = x;
            }
        }

        private void mahoa(int[,] a, int[] f, int[] g, char[] h, int m, int n)
        {
            int so = 0;
            for (int i = 0; i < m; i += n)// mã hóa n số một lần .
            {
                for (int k = 0; k < n; k++) // chạy cột trước .
                {
                    int x = 0;
                    int y = i;

                    for (int l = 0; l < n; l++) // chạy hàng sau .
                    {
                        x += f[y] * a[l,k];
                        y++;
                    }
                    int z = x;
                    x = 0;
                    y = i;
                    g[so] = z % 26;
                    so++;

                }
            }
            for (int i = 0; i < m; i++)
            {
                h[i] = Convert.ToChar(g[i] + 97);
            }
            h[m] = '\0';
        }

        private void giaima(int[,] a, int[] f, int[] g, char[] h, int m, int n)
        {
            int so = 0;
            for (int i = 0; i < m; i += n)
            {
                for (int k = 0; k < n; k++)
                {
                    int x = 0;
                    int y = i;
                    for (int l = 0; l < n; l++)  
                    {
                        x += f[y] * a[l,k];
                        y++;
                    }
                    int z = x;
                    x = 0;
                    y = i;

                    g[so] = z % 26;
                    so++;
                }
            }
            string kt = "";
            for (int i = 0; i < m; i++)
            {
                h[i] = Convert.ToChar(g[i] + 97);
            }
            h[m] = '\0';
        }
    }
}
