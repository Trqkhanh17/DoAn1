using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
namespace QuanLyHocSinh
{
    public class function
    {
        //hàm check dữ liệu có phải là số không
        public bool checkNum(string num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //hàm check dữ liệu có bắt đầu là số 0 hay không
        public bool checkStart(string num)
        {
            try
            {
                char[] tokens = num.ToCharArray();

                if (tokens[0] == '0')
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkStartStudent(string MaHS)
        {
            try
            {
                string sum = "";
                char[] tokens = MaHS.ToLower().ToCharArray();
                for (int i = 0; i < 7; i++)
                {
                    sum += tokens[i];
                }
                if (sum == "student")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkStartTeacher(string MaGV)
        {
            try
            {
                string sum = "";
                char[] tokens = MaGV.ToLower().ToCharArray();
                for (int i = 0; i < 7; i++)
                {
                    sum += tokens[i];
                }
                if (sum == "teacher")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkKiTuDatBiet(string chuoiCanKiemTra)
        {
            string camKiTu = @"[!@#$%^&*()_+{}\[\]:;<>,.?/~`\\|= ""'–-]";
            if (Regex.IsMatch(chuoiCanKiemTra,camKiTu))
            {
                return true ;
            }
            else
            {
                return false;
            }
        }
        public bool checkKiTuDatBiet_Ten(string chuoiCanKiemTra)
        {
            string camKiTu = @"[!@#$%^&*()_+{}\[\]:;<>,.?/~`\\|=""'–-]";
            if (Regex.IsMatch(chuoiCanKiemTra, camKiTu))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkNgaySinh(DateTime ngaySinh)
        {
           return ngaySinh.Year < DateTime.Now.Year;
        }
        public void CustomTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Times New Roman", 10);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
        }
        public void CustomButton(Button button)
        {
            button.Font = new Font("Times New Roman", 10);
            button.BackColor = Color.Navy;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.DarkSlateBlue;
        }
        public void CustomCheckBox(CheckBox checkBox)
        {
            checkBox.Font = new Font("Times New Roman", 10);
            checkBox.BackColor = Color.Transparent;  // Thường để trong suốt để phù hợp với nền
            checkBox.ForeColor = Color.Black;
        }
        public void CustomeDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày/tháng/năm
            dateTimePicker.Value = DateTime.Today; // Hiển thị ngày hôm nay

        }
        public void CustomComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Times New Roman", 10);
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.FlatStyle = FlatStyle.Flat;

        }
        public void CustomizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.DefaultCellStyle.Padding = new Padding(5);
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
        }
        public void CustomMenuStrip(MenuStrip menuStrip)
        {
            menuStrip.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            menuStrip.BackColor = Color.LightGray; 
            menuStrip.ForeColor = Color.Black; 
        }

    }
}
