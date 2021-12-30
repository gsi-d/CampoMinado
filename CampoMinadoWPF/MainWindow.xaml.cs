using DocumentFormat.OpenXml.Spreadsheet;
using IronPython.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;
using Colors = System.Windows.Media.Colors;

namespace CampoMinadoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Button> campos = new List<Button>();
        public List<string> conteudoBotao = new List<string>();
        int contadorBomba = 0;
        int segundos = 0;
        int movimentos = 0;
        int contadorVitoria = 81;
        public DispatcherTimer timer = new DispatcherTimer();


        public MainWindow()
        {
            InitializeComponent();
            gerarCampos();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            ttbTimer.Text = segundos.ToString("000");
        }

        private string gerarNumeroAleatorio()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 7);

            switch (numeroAleatorio)
            {
                case 0:
                    return "";
                case 1:
                    return "";
                case 2:
                    return "";
                case 3:
                    return "";
                case 4:
                    contadorBomba += 1;
                    if (contadorBomba <= 10)
                        return "💣";
                    else
                        return "";
                case 5:
                    return "";
                case 6:
                    return "";
                default:
                    return "";
            }
            
        }

        private void gerarCampos()
        {
            campos.Add(btn0);
            campos.Add(btn1);
            campos.Add(btn2);
            campos.Add(btn3);
            campos.Add(btn4);
            campos.Add(btn5);
            campos.Add(btn6);
            campos.Add(btn7);
            campos.Add(btn8);
            campos.Add(btn9);
            campos.Add(btn10);
            campos.Add(btn11);
            campos.Add(btn12);
            campos.Add(btn13);
            campos.Add(btn14);
            campos.Add(btn15);
            campos.Add(btn16);
            campos.Add(btn17);
            campos.Add(btn18);
            campos.Add(btn19);
            campos.Add(btn20);
            campos.Add(btn21);
            campos.Add(btn22);
            campos.Add(btn23);
            campos.Add(btn24);
            campos.Add(btn25);
            campos.Add(btn26);
            campos.Add(btn27);
            campos.Add(btn28);
            campos.Add(btn29);
            campos.Add(btn30);
            campos.Add(btn31);
            campos.Add(btn32);
            campos.Add(btn33);
            campos.Add(btn34);
            campos.Add(btn35);
            campos.Add(btn36);
            campos.Add(btn37);
            campos.Add(btn38);
            campos.Add(btn39);
            campos.Add(btn40);
            campos.Add(btn41);
            campos.Add(btn42);
            campos.Add(btn43);
            campos.Add(btn44);
            campos.Add(btn45);
            campos.Add(btn46);
            campos.Add(btn47);
            campos.Add(btn48);
            campos.Add(btn49);
            campos.Add(btn50);
            campos.Add(btn51);
            campos.Add(btn52);
            campos.Add(btn53);
            campos.Add(btn54);
            campos.Add(btn55);
            campos.Add(btn56);
            campos.Add(btn57);
            campos.Add(btn58);
            campos.Add(btn59);
            campos.Add(btn60);
            campos.Add(btn61);
            campos.Add(btn62);
            campos.Add(btn63);
            campos.Add(btn64);
            campos.Add(btn65);
            campos.Add(btn66);
            campos.Add(btn67);
            campos.Add(btn68);
            campos.Add(btn69);
            campos.Add(btn70);
            campos.Add(btn71);
            campos.Add(btn72);
            campos.Add(btn73);
            campos.Add(btn74);
            campos.Add(btn75);
            campos.Add(btn76);
            campos.Add(btn77);
            campos.Add(btn78);
            campos.Add(btn79);
            campos.Add(btn80);

            for (int i = 0; i < 81; i++)
            {
                conteudoBotao.Add(gerarNumeroAleatorio());
            }
            for (int i = 0; i < 81; i++)
            {
                int bombas = 0;
                if (conteudoBotao[i] != "💣")
                {
                    if ((i==9) || (i == 18) || (i == 27) || (i == 36) || (i == 45) || (i == 54) || (i == 63))
                    {
                        if ((i + 1 <= 80) && conteudoBotao[i + 1] == "💣")
                            bombas += 1;
                        if ((i - 8 >= 0) && conteudoBotao[i - 8] == "💣")
                            bombas += 1;
                        if ((i - 9 >= 0) && conteudoBotao[i - 9] == "💣")
                            bombas += 1;
                        if ((i + 9 <= 80) && conteudoBotao[i + 9] == "💣")
                            bombas += 1;
                        
                    }
                    else if ((i==17) || (i == 26) || (i == 35) || (i == 44) || (i == 53) || (i == 62) || (i == 71))
                    {
                        if ((i - 1 >= 0) && conteudoBotao[i - 1] == "💣")
                            bombas += 1;
                        if ((i + 8 <= 80) && conteudoBotao[i + 8] == "💣")
                            bombas += 1;
                        if ((i - 9 >= 0) && conteudoBotao[i - 9] == "💣")
                            bombas += 1;
                        if ((i + 9 <= 80) && conteudoBotao[i + 9] == "💣")
                            bombas += 1;
                        
                    }
                    else if (i == 0)
                    {
                        if ((i + 1 <= 80) && conteudoBotao[i + 1] == "💣")
                            bombas += 1;
                        if ((i + 9 <= 80) && conteudoBotao[i + 9] == "💣")
                            bombas += 1;
                        if ((i + 10 <= 80) && conteudoBotao[i + 10] == "💣")
                            bombas += 1;
                    }
                    else if (i == 8)
                    {
                        if ((i - 1 >= 0) && conteudoBotao[i - 1] == "💣")
                            bombas += 1;
                        if ((i + 9 <= 80) && conteudoBotao[i + 9] == "💣")
                            bombas += 1;
                        if ((i + 8 <= 80) && conteudoBotao[i + 8] == "💣")
                            bombas += 1;
                    }
                    else if (i == 72)
                    {
                        if ((i + 1 <= 80) && conteudoBotao[i + 1] == "💣")
                            bombas += 1;
                        if ((i - 9 >= 0) && conteudoBotao[i - 9] == "💣")
                            bombas += 1;
                        if ((i - 8 >= 0) && conteudoBotao[i - 8] == "💣")
                            bombas += 1;
                    }
                    else if (i == 80)
                    {
                        if ((i - 1 >= 0) && conteudoBotao[i - 1] == "💣")
                            bombas += 1;
                        if ((i - 9 >= 0) && conteudoBotao[i - 9] == "💣")
                            bombas += 1;
                        if ((i - 10 >= 0) && conteudoBotao[i - 10] == "💣")
                            bombas += 1;
                    }
                    else
                    {
                        if ((i - 1 >= 0) && conteudoBotao[i - 1] == "💣")
                            bombas += 1;
                        if ((i + 1 <= 80) && conteudoBotao[i + 1] == "💣")
                            bombas += 1;
                        if ((i - 9 >= 0) && conteudoBotao[i - 9] == "💣")
                            bombas += 1;
                        if ((i + 9 <= 80) && conteudoBotao[i + 9] == "💣")
                            bombas += 1;
                        if ((i - 8 >= 0) && conteudoBotao[i - 8] == "💣")
                            bombas += 1;
                        if ((i + 8 <= 80) && conteudoBotao[i + 8] == "💣")
                            bombas += 1;
                        if ((i - 10 >= 0) && conteudoBotao[i - 10] == "💣")
                            bombas += 1;
                        if ((i + 10 <= 80) && conteudoBotao[i + 10] == "💣")
                            bombas += 1;
                    }

                    switch (bombas)
                    {
                        case 0:
                            conteudoBotao[i] = "";
                            break;
                        case 1:
                            conteudoBotao[i] = "1";
                            break;
                        case 2:
                            conteudoBotao[i] = "2";
                            break;
                        case 3:
                            conteudoBotao[i] = "3";
                            break;
                        case 4:
                            conteudoBotao[i] = "4";
                            break;
                    }
                }
            }
        }

        private void conferirConteudo(Button button)
        {

            contadorVitoria = 81;
            for (int i = 0; i < 81; i++)
            {
                if (campos[i] == button)
                {
                    if (conteudoBotao[i] == "💣")
                    {
                        campos[i].Content = "💣";
                    }
                    else
                    {
                        campos[i].Content = conteudoBotao[i];
                    }
                    campos[i].IsEnabled = false;

                    if (campos[i].Content.ToString() == "💣")
                    {
                        if(campos[i].IsMouseCaptured)
                            campos[i].Background = Brushes.Red;
                        for (int j = 0; j < 81; j++)
                        {
                            if (conteudoBotao[j] == "💣")
                            {
                                campos[j].Content = conteudoBotao[j];
                                campos[j].IsEnabled = false;
                                for (int z = 0; z < 81; z++)
                                {
                                    campos[z].IsEnabled = false;
                                }
                                timer.Stop();
                            }
                        }
                    }
                    if (campos[i].Content.ToString() == "")
                    {
                        if ((i - 9 >= 0) && (conteudoBotao[i - 9] != "💣") && campos[i - 9].IsEnabled)
                        {
                            campos[i - 9].Content = conteudoBotao[i - 9];
                            campos[i - 9].IsEnabled = false;
                        }
                        if ((i + 9 <= 80) && (conteudoBotao[i + 9] != "💣") && campos[i + 9].IsEnabled)
                        {
                            campos[i + 9].Content = conteudoBotao[i + 9];
                            campos[i + 9].IsEnabled = false;
                        }
                        if ((i + 1 <= 80) && (conteudoBotao[i + 1] != "💣") && campos[i + 1].IsEnabled)
                        {
                            campos[i + 1].Content = conteudoBotao[i + 1];
                            campos[i + 1].IsEnabled = false;
                        }
                        if ((i - 1 >= 0) && (conteudoBotao[i - 1] != "💣") && campos[i - 1].IsEnabled)
                        {
                            campos[i - 1].Content = conteudoBotao[i - 1];
                            campos[i - 1].IsEnabled = false;
                        }
                        if ((i - 10 >= 0) && (conteudoBotao[i - 10] != "💣") && campos[i - 10].IsEnabled)
                        {
                            campos[i - 10].Content = conteudoBotao[i - 10];
                            campos[i - 10].IsEnabled = false;
                        }
                        if ((i + 10 <= 80) && (conteudoBotao[i + 10] != "💣") && campos[i + 10].IsEnabled)
                        {
                            campos[i + 10].Content = conteudoBotao[i + 10];
                            campos[i + 10].IsEnabled = false;
                        }
                        if ((i + 11 <= 80) && (conteudoBotao[i + 11] != "💣") && campos[i + 11].IsEnabled)
                        {
                            campos[i + 11].Content = conteudoBotao[i + 11];
                            campos[i + 11].IsEnabled = false;
                        }
                        if ((i - 11 >= 0) && (conteudoBotao[i - 11] != "💣") && campos[i - 11].IsEnabled)
                        {
                            campos[i - 11].Content = conteudoBotao[i - 11];
                            campos[i - 11].IsEnabled = false;
                        }
                    }
                }
                if (!campos[i].IsEnabled)
                    contadorVitoria -= 1;
            }

            if (contadorVitoria == 10)
            {
                timer.Stop();
                for (int i = 0; i < 81; i++)
                {
                    if (campos[i].IsEnabled)
                    {
                        campos[i].Content = "✓";
                        campos[i].IsEnabled = false;
                    }
                }
                MessageBox.Show("VOCÊ VENCEU!!");
            }
        }

        private void click00(object sender, RoutedEventArgs e)
        {
            movimentos++;
            ttbMoviments.Text = "0" + movimentos;
            Button iButton = (Button)sender;
            for (int i = 0; i < 81; i++)
            {
                if (iButton.Name == "btn" + i)
                {
                    conferirConteudo(campos[i]);
                }
            }

        }

        private void clickReset(object sender, RoutedEventArgs e)
        {
            for (int i = 80; i >= 0; i--)
            {
                campos[i].Content = null;
                campos[i].IsEnabled = true;
            }
            contadorBomba = 0;
            conteudoBotao.Clear();
            gerarCampos();
            segundos = 0;
            movimentos = 0;
            ttbTimer.Text = "000";
            ttbMoviments.Text = "00";
            timer.Start();
        }
    }
}

