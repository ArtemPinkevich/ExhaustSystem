using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kompas6API5;
using Kompas6Constants3D;
using System.Diagnostics;

namespace Silencer
{
    public partial class FormData : Form
    {
        /// <summary>
        /// Класс построитель
        /// </summary>
        private ManagerKompas _managerKompas = new ManagerKompas();

        /// <summary>
        /// Модель данных (выхлопная система)
        /// </summary>
        private ExhaustSystem _exhaustSystem = new ExhaustSystem();

        public FormData()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Нагрузочное тестирование
        /// </summary>
        /// <param name="repeat"></param>
        private void LoadTesting(int repeat)
        {
            TimeSpan _tSpan;

            for (int i = 0; i < 1; i++)
            {
                var _stopwatch = new Stopwatch();
                _stopwatch.Start();

                SetParameters();
                string _resultCheck = _exhaustSystem.CheckData();

                if (_resultCheck == "Ошибки в параметрах:\n")
                {
                    _managerKompas.CreateExhaustSystem(_exhaustSystem);
                }
                else
                {
                    MessageBox.Show(_resultCheck);
                }

                _stopwatch.Stop();
                //Console.WriteLine(" ");
                //Console.WriteLine("Время: ");
                _tSpan = _stopwatch.Elapsed;
                //Console.WriteLine(_tSpan.ToString());
                Console.WriteLine(_stopwatch.Elapsed.Seconds.ToString() + "." + _stopwatch.Elapsed.Milliseconds.ToString());
            }

        }
        
        /// <summary>
        /// Установка параметров в модель данных
        /// </summary>
        private void SetParameters()
        {
            // Глушитель
            _exhaustSystem.Silencer.Length = (Convert.ToDouble(txtSilencerLength.Text));
            _exhaustSystem.Silencer.Width = (Convert.ToDouble(txtSilenserWidth.Text));
            _exhaustSystem.Silencer.Height = (Convert.ToDouble(txtSilenserHeight.Text));

            // Выходящая труба
            _exhaustSystem.OutputPipe.Length = Convert.ToDouble(txtPipeOutLength.Text);
            _exhaustSystem.OutputPipe.Diameter = Convert.ToDouble(txtPipeOutDiameter.Text);
            _exhaustSystem.OutputPipe.InnerDiameter = Convert.ToDouble(txtPipeOutInnerDiameter.Text);

            // Входящая труба
            _exhaustSystem.InputPipe.Diameter = Convert.ToDouble(txtPipeInDiameter.Text);
            _exhaustSystem.InputPipe.InnerDiameter = Convert.ToDouble(txtPipeInInnerDiameter.Text);

            // Изгиб
            _exhaustSystem.InputPipe.Bend.LengthBefore = Convert.ToDouble(txtBendLength.Text);
            _exhaustSystem.InputPipe.Bend.Radius = Convert.ToDouble(txtBendRadius.Text);
            _exhaustSystem.InputPipe.Bend.Angle = Convert.ToDouble(txtBendAngle.Text);
        }

        /// <summary>
        /// Обработка нажатия клавиш в textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Если не цифра и не запятая (которая не первая и ещё не было)
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
            {
                // Если не BackSpace
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }

            // Без запятой 3 знака
            if ( !(e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(",") == -1) && 
                ((TextBox)sender).Text.Length > 2)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }

            // 2 знака после запятой
            if ((((TextBox)sender).Text.IndexOf(",") != -1) &&
                ((TextBox)sender).Text.Length > ((TextBox)sender).Text.IndexOf(",") + 2)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Обработка пустого textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSpace_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                lblError.Visible = true;
                btnStart.Enabled = false;
            }
            else
            {
                lblError.Visible = false;
                btnStart.Enabled = true;
            }
        }

        /// <summary>
        /// Задает фон textBox белым при активизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1SilencerL_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        /// <summary>
        /// Запуск построения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            SetParameters();
            string _resultCheck = _exhaustSystem.CheckData();

            if (_resultCheck == "Ошибки в параметрах:\n")
            {
                _managerKompas.CreateExhaustSystem(_exhaustSystem);
            }
            else
            {
                MessageBox.Show(_resultCheck);
            }
        }

    }
}
