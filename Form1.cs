using System.Reflection;

namespace TotitoSE
{
    public partial class Form1 : Form
    {
        public string PlayerName1 { get; private set; } = "";
        public string PlayerName2 { get; private set; } = "";
        string SelectedIcon = "X";
        string CurrentIcon = "X";
        public Form1()
        {
            InitializeComponent();
            MostrarFormularioPlayerName1();
            MostrarFormularioPlayerName2();
            label1.Text = PlayerName1;
            label2.Text = PlayerName2;
            MostrarFormularioSelectPlayerIcon();
            label4.Text = "¡Turno de " + PlayerName1 + "!";
        }

        private void MostrarFormularioPlayerName1()
        {
            using var formularioPlayerName1 = new Player1Name();
            formularioPlayerName1.FormClosed += (sender, e) =>
            {
                PlayerName1 = formularioPlayerName1.PlayerName1;
            };

            formularioPlayerName1.ShowDialog();
        }

        private void MostrarFormularioPlayerName2()
        {
            using var formularioPlayerName2 = new Player2Name();
            formularioPlayerName2.FormClosed += (sender, e) =>
            {
                PlayerName2 = formularioPlayerName2.PlayerName2;
            };

            formularioPlayerName2.ShowDialog();
        }

        private void MostrarFormularioSelectPlayerIcon()
        {
            using var FormPlayerIcon = new SelectPlayerIcon(PlayerName1);
            FormPlayerIcon.FormClosed += (sender, e) =>
            {
                CurrentIcon = FormPlayerIcon.CurrentIcon;
                SelectedIcon = FormPlayerIcon.CurrentIcon;
            };

            FormPlayerIcon.ShowDialog();
        }

        private void Button_Click_Totito(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "" && CurrentIcon != null)
            {
                button.Text = CurrentIcon;
                Boolean someOneWin = ValidateIfSomeOneWin();
                if (someOneWin)
                {
                    string winner = GetCurrentUser();
                    label4.Text = winner + " has ganado!.";
                    using var formWinnerScreen = new WinnnerScreen(winner);
                    formWinnerScreen.ShowDialog();
                    RestartGame(sender, e);
                    return;
                }
                else
                {
                    Boolean finishTheGame = ValidateFinishTheGame();
                    if (finishTheGame)
                    {
                        label4.Text = "  Ninguno ha Ganado :(";
                        timer1.Start();
                        return;
                    }
                }
                Change_User();
            }
        }

        private string GetCurrentUser()
        {
            if (label4.Text == "¡Turno de " + PlayerName1 + "!")
            {
                return PlayerName1;
            }
            else
            {
                return PlayerName2;
            }
        }

        private void Change_User()
        {
            if (CurrentIcon != null)
            {
                if (CurrentIcon == "X")
                {
                    CurrentIcon = "0";
                    ChangeTurnText();
                }
                else if (CurrentIcon == "0")
                {
                    CurrentIcon = "X";
                    ChangeTurnText();
                }
            }
        }

        private void ChangeTurnText()
        {
            if (label4.Text == "¡Turno de " + PlayerName1 + "!")
            {
                label4.Text = "¡Turno de " + PlayerName2 + "!";
            }
            else
            {
                label4.Text = "¡Turno de " + PlayerName1 + "!";
            }
        }

        private Boolean ValidateIfSomeOneWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (!string.IsNullOrWhiteSpace(button1.Text) && !string.IsNullOrWhiteSpace(button2.Text) && !string.IsNullOrWhiteSpace(button3.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (!string.IsNullOrWhiteSpace(button4.Text) && !string.IsNullOrWhiteSpace(button5.Text) && !string.IsNullOrWhiteSpace(button6.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (!string.IsNullOrWhiteSpace(button7.Text) && !string.IsNullOrWhiteSpace(button8.Text) && !string.IsNullOrWhiteSpace(button9.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (!string.IsNullOrWhiteSpace(button1.Text) && !string.IsNullOrWhiteSpace(button4.Text) && !string.IsNullOrWhiteSpace(button7.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (!string.IsNullOrWhiteSpace(button2.Text) && !string.IsNullOrWhiteSpace(button5.Text) && !string.IsNullOrWhiteSpace(button8.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (!string.IsNullOrWhiteSpace(button3.Text) && !string.IsNullOrWhiteSpace(button6.Text) && !string.IsNullOrWhiteSpace(button9.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (!string.IsNullOrWhiteSpace(button1.Text) && !string.IsNullOrWhiteSpace(button5.Text) && !string.IsNullOrWhiteSpace(button9.Text))
                {
                    return true;
                }
                return false;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (!string.IsNullOrWhiteSpace(button3.Text) && !string.IsNullOrWhiteSpace(button5.Text) && !string.IsNullOrWhiteSpace(button7.Text))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private Boolean ValidateFinishTheGame()
        {
            if (!string.IsNullOrWhiteSpace(button1.Text) &&
                !string.IsNullOrWhiteSpace(button2.Text) &&
                !string.IsNullOrWhiteSpace(button3.Text) &&
                !string.IsNullOrWhiteSpace(button4.Text) &&
                !string.IsNullOrWhiteSpace(button5.Text) &&
                !string.IsNullOrWhiteSpace(button6.Text) &&
                !string.IsNullOrWhiteSpace(button7.Text) &&
                !string.IsNullOrWhiteSpace(button8.Text) &&
                !string.IsNullOrWhiteSpace(button9.Text)
            ) return true;
            return false;
        }

        private void RestartGame(object sender, EventArgs e)
        {
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            label4.Text = "¡Turno de " + PlayerName1 + "!";
            CurrentIcon = SelectedIcon;
        }

        private void RestarGameByTimer(object sender, EventArgs e)
        {
            RestartGame(sender, e);
            timer1.Stop();
        }

        private void Restart(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
