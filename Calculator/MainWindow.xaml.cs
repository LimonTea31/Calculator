using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public void EmulateButtonClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(Button.ClickEvent);
            btn6.RaiseEvent(args);
            btnFact.RaiseEvent(args);
        }
        public void ForTestDivide()
        {
            RoutedEventArgs args = new RoutedEventArgs(Button.ClickEvent);
            btn3.RaiseEvent(args);
            btn6.RaiseEvent(args);
            btnDivide.RaiseEvent(args);
            btn6.RaiseEvent(args);
            btnEqually.RaiseEvent(args);
        }
        public void ForTestExp()
        {
            RoutedEventArgs args = new RoutedEventArgs(Button.ClickEvent);
            btn2.RaiseEvent(args);
            btn6.RaiseEvent(args);
            btnDivide.RaiseEvent(args);
            btnZero.RaiseEvent(args);
            btnEqually.RaiseEvent(args);
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public decimal FirstChislo = 0;
        public decimal SecondChislo = 0;
        public bool solved = false;
        public decimal rez = 0;

        public bool Click = false;
        public bool Plus = false;
        public bool Minus = false;
        public bool Multiply = false;
        public bool Divide = false;

        public string tbZnach = "";

        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("1");
            
        }

        public void btn2_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("2");
        }

        public void btn3_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("3");
        }

        public void btn4_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("4");
        }

        public void btn5_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("5");
        }

        public void btn6_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("6");
        }

        public void btn7_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("7");
        }

        public void btn8_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("8");
        }

        public void btn9_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("9");
        }

        public void btnZero_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText("0");
        }

        public void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            if (CheckCommas(tbResult.Text))
            {
            }
            else if(tbResult.Text.Length != 0)
            {
                tbResult.AppendText(",");
            }
        }

        public void btnDell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbResult.Text.Length > 0)
                {
                    tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1);
                }
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Ошибка деление на 0");
            }
        }

        public void btnC_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        public void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbResult.Text.Length > 0 & tbResult.Text[0] != '-')
                {
                    tbResult.Text = '-' + tbResult.Text;
                }
                else if(tbResult.Text.Length > 0)
                {
                    tbResult.Text = tbResult.Text.Substring(1);
                }
            }
            catch(Exception)
            {
                //MessageBox.Show("");
            }
        }

        public void btnOtcritScob_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clear();
                Regex regex = new Regex("(");
                regex.IsMatch(tbResult.Text);
                if (regex.IsMatch(tbResult.Text))
                {
                }
                else if (tbResult.Text.Length != 0)
                {
                    tbResult.AppendText("(");
                }
            }
            catch (Exception)
            {
                tbResult.Text = "Error";
            }
           

        }

        public void btnZacritScob_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            tbResult.AppendText(")");
        }

        public void btnFact_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length > 0)
            {
                if (decimal.Parse(tbResult.Text) < 65)
                {
                    if(CheckCommas(tbResult.Text))
                    {
                    }
                    else {
                        FirstChislo = Factorial(ulong.Parse(tbResult.Text));
                        tbResult.Text = FirstChislo.ToString();
                        FirstChislo = 0;
                    }
                }
                else { tbResult.Text = "Ошибка!"; }
                    
            }
            solved = true;
        }
        public static ulong Factorial(ulong n)
        {
            
            ulong result = 1;
            for (ulong i = 1; i <= n; i++){
             result *= i;
            }
            return result;
           
        }
        public void Clear()
        {
            if (solved == true)
            {
                tbResult.Text = "";
                solved = false;
            }
        }
        public void ClearAll()
        {
            tbResult.Text = "";
            FirstChislo = 0;
            SecondChislo = 0;
            solved = false;
            rez = 0;
        }

        public void btnMC_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        public void btnMplus_Click(object sender, RoutedEventArgs e)
        {
            if(tbResult.Text != null)
            {
                rez += ulong.Parse(tbResult.Text);
            }
        }

        public void btnMR_Click(object sender, RoutedEventArgs e)
        {
            if(rez != 0)
            {
                tbResult.Text = rez.ToString();
            }
        }
        static bool CheckCommas(string inputString)
        {
            Regex regex = new Regex(",");
            return regex.IsMatch(inputString);
        }

        public void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length > 0 && Click != true)
            {
                FirstChislo = decimal.Parse(tbResult.Text);
                Click = true;
            }
            else
            {
                SecondChislo = decimal.Parse(tbResult.Text);
                FirstChislo += SecondChislo;
                tbResult.Text = FirstChislo.ToString();
                Click = false;
            }
            solved = true;
            Plus = true;
            Minus = false;
            Multiply = false;
            Divide = false;
            tbZnach = tbResult.Text;
        }

        public void btnEqually_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                SecondChislo = decimal.Parse(tbResult.Text);
                if (Plus == true)
                {
                    tbResult.Text = (FirstChislo + SecondChislo).ToString();
                    Plus = false;
                }
                else if (Minus == true)
                {
                    tbResult.Text = (FirstChislo - SecondChislo).ToString();
                    Minus = false;
                }
                else if (Multiply == true)
                {
                    tbResult.Text = (FirstChislo * SecondChislo).ToString();
                    Multiply = false;
                }
                else if (Divide == true)
                {
                    tbResult.Text = (FirstChislo / SecondChislo).ToString();
                    Divide = false;
                }
                FirstChislo = 0;
                SecondChislo = 0;
                solved = true;
                Click = false;
                tbZnach = tbResult.Text;
            }
            catch(DivideByZeroException ex)
            {
                solved = true;
                Click = false;
                tbResult.Text = "Ошибка деления на 0";
                tbZnach = tbResult.Text;
            }
           
        }

        public void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length > 0 && Click != true)
            {
                FirstChislo = decimal.Parse(tbResult.Text);
                Click = true;
            }
            else
            {
                SecondChislo = decimal.Parse(tbResult.Text);
                tbResult.Text = (FirstChislo - SecondChislo).ToString();
                Click = false;
            }
            solved = true;
            Plus = false;
            Minus = true;
            Multiply = false;
            Divide = false;
            tbZnach = tbResult.Text;
        }

        public void btnMminus_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text != null)
            {
                rez -= ulong.Parse(tbResult.Text);
            }
            tbZnach = tbResult.Text;
        }

        public void btnMS_Click(object sender, RoutedEventArgs e)
        {
            rez = 0;
        }

        public void btnCE_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "";
        }

        public void btnFractional_Click(object sender, RoutedEventArgs e)
        {
            if(tbResult.Text.Length != 0)
            {
                tbResult.Text = (1 / decimal.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Sqrt(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnProcent_Click(object sender, RoutedEventArgs e)
        {
            
            if (FirstChislo != 0)
            {
                decimal Procent = (decimal.Parse(tbResult.Text) * FirstChislo) / 100;
                if (Plus == true)
                {
                    tbResult.Text = (FirstChislo + Procent).ToString();
                    Plus = false;
                }
                else if (Minus == true)
                {
                    tbResult.Text = (FirstChislo - Procent).ToString();
                    Minus = false;
                }
                else if (Multiply == true)
                {
                    tbResult.Text = (FirstChislo * Procent).ToString();
                    Multiply = false;
                }
                else if (Divide == true)
                {
                    tbResult.Text = (FirstChislo / Procent).ToString();
                    Divide = false;
                }
                else
                {
                    tbResult.Text = Procent.ToString();
                }
                solved = true;
                
            }
            tbZnach = tbResult.Text;
        }

        public void btn10StepenX_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = (double.Parse(tbResult.Text) * 10).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnLog_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Log(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnMod_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Abs(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnExp_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Exp(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnTan_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Tan(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnTanh_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Tanh(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnCos_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Cos(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnCosh_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Cosh(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnSin_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Sin(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnSinh_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Sinh(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnLn_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Log10(double.Parse(tbResult.Text)).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnFE_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                FirstChislo = decimal.Parse(tbResult.Text);
            }
            tbResult.Text = "254";
            solved = true;
            tbZnach = tbResult.Text;
        }

        public void btnPi_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                FirstChislo = decimal.Parse(tbResult.Text);
            }
            tbResult.Text = "3,14";
            solved = true;
            tbZnach = tbResult.Text;
        }

        public void btnDms_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "Ошибка";
            solved = true;
            tbZnach = tbResult.Text;
        }

        public void btnCvadrat_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Pow(double.Parse(tbResult.Text),2).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnCubStep_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
                tbResult.Text = Math.Pow(double.Parse(tbResult.Text), 3).ToString();
                solved = true;
            }
            tbZnach = tbResult.Text;
        }

        public void btnCubCoren_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length != 0)
            {
               
            }
            tbZnach = tbResult.Text;
        }

        public void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (tbResult.Text.Length > 0 && Click != true)
            {
                FirstChislo = decimal.Parse(tbResult.Text);
                Click = true;
            }
            else
            {
                SecondChislo = decimal.Parse(tbResult.Text);
                tbResult.Text = (FirstChislo * SecondChislo).ToString();
                Click = false;
            }
            solved = true;
            Plus = false;
            Minus = false;
            Multiply = true;
            Divide = false;
            tbZnach = tbResult.Text;
        }


        public void tbResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbZnach = tbResult.Text;
        }

        private void btnDivide_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbResult.Text.Length > 0 && Click != true)
                {
                    FirstChislo = decimal.Parse(tbResult.Text);
                    Click = true;
                }
                else
                {
                    SecondChislo = decimal.Parse(tbResult.Text);
                    tbResult.Text = (FirstChislo / SecondChislo).ToString();
                    Click = false;
                }
                solved = true;
                Plus = false;
                Minus = false;
                Multiply = false;
                Divide = true;
                tbZnach = tbResult.Text;
            }
            catch(DivideByZeroException Ex)
            {
                solved = true;
                Click = false;
                tbResult.Text = "Ошибка деления на 0";
                tbZnach = tbResult.Text;
            }
           
        }
    }
}
