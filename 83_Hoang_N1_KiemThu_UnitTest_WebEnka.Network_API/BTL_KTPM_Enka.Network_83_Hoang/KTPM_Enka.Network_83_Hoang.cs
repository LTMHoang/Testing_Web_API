using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using CsvHelper;
using System.Globalization;
using OpenQA.Selenium.DevTools.V121.Overlay;
using System.Security.Cryptography;

namespace BTL_KTPM_Enka.Network_83_Hoang
{
    public partial class KTPM_Enka_83_Hoang : Form
    {
        private static ChromeDriverService chrome_83_Hoang;

        private static IWebDriver driver_83_Hoang;

        public KTPM_Enka_83_Hoang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Test_TimKiem_83_Hoang_Click(object sender, EventArgs e)
        {
            // Gán đường dẫn cố định cho file CSV
            // Test Case 1: test_1_TimKiem_UIDTonTai_DungGame
            string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\TimKiem\TestData_UIDTonTai_DungGame_83_Hoang.csv";

            //// Test Case 2: test_2_TimKiem_UIDTonTai_SaiGame
            //string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\TimKiem\TestData_UIDTonTai_SaiGame_83_Hoang.csv";

            //// Test Case 3: test_3_TimKiem_UIDKhongTonTai
            //string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\TimKiem\TestData_UIDKhongTonTai_83_Hoang.csv";

            // Đóng cửa sổ cmd
            chrome_83_Hoang = ChromeDriverService.CreateDefaultService();
            chrome_83_Hoang.HideCommandPromptWindow = true;

            // Link web để thực hiện kiểm thử chức năng tìm kiếm
            String link_web_search_83_Hoang = "https://enka.network/";

            // Khởi tạo Driver cho trang web và dẫn đến trang web
            driver_83_Hoang = new ChromeDriver(chrome_83_Hoang);
            driver_83_Hoang.Navigate().GoToUrl(link_web_search_83_Hoang);

            // Kiểm tra xem file có tồn tại không trước khi đọc
            if (File.Exists(filePath_83_Hoang))
            {
                // Đọc tất cả các dòng từ file CSV
                var lines_83_Hoang = File.ReadAllLines(filePath_83_Hoang);

                // Bỏ qua dòng đầu tiên (tiêu đề) và xử lý từ dòng thứ hai
                for (int i = 1; i < lines_83_Hoang.Length; i++)
                {
                    string[] fields_83_Hoang = lines_83_Hoang[i].Split(',');

                    if (fields_83_Hoang.Length == 2)  // Đảm bảo mỗi dòng có 2 phần tử
                    {
                        // Lấy và làm sạch UID
                        string uid_83_Hoang = fields_83_Hoang[0].Trim();

                        // Lấy Element ô tìm kiếm bằng ClassName
                        driver_83_Hoang.FindElement(By.ClassName("uid")).SendKeys(uid_83_Hoang);

                        // Nghỉ 2 giây
                        Thread.Sleep(2000);

                        // Lấy và làm sạch tên game
                        string game_83_Hoang = fields_83_Hoang[1].Trim();

                        // Lấy Element game bằng ClassName
                        driver_83_Hoang.FindElement(By.ClassName(game_83_Hoang)).Click();

                        // Nghỉ 2 giây
                        Thread.Sleep(2000);

                        // Lấy Element nút tìm kiếm bằng XPath
                        driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[2]/div/button")).Click();
                    }
                    // Nghỉ 10 giây
                    Thread.Sleep(10000);

                    // Quay trở lại trang trước
                    driver_83_Hoang.Navigate().Back();

                    // Reset lại ô tìm kiếm
                    driver_83_Hoang.FindElement(By.ClassName("uid")).Clear();
                }
                // Thoát khỏi trang web
                driver_83_Hoang.Close();
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Test_DangNhap_83_Hoang_Click(object sender, EventArgs e)
        {
            // Gán đường dẫn cố định cho file CSV
            // Test Case 1: test_1_DangNhap_EmailDaDangKy_DungPass
            string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\DangNhap\TestData_EmailDaDangKy_DungPass_83_Hoang.csv";

            //// Test Case 2: test_2_DangNhap_EmailDaDangKy_SaiPass
            //string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\DangNhap\TestData_EmailDaDangKy_SaiPass_83_Hoang.csv";

            //// Test Case 3: test_3_DangNhap_EmailChuaDangKy
            //string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\BTL_KTPM_Enka.Network_83_Hoang\Data\DangNhap\TestData_EmailChuaDangKy_83_Hoang.csv";

            //// Test Case 4: test_4_DangNhap_EmailSaiDinhDang
            //string filePath_83_Hoang = @"E:\MY_STUDY\CODE\C#\BTL_KTPM_83_Hoang\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_APIg\BTL_KTPM_Enka.Network_83_Hoang\Data\DangNhap\TestData_EmailSaiDinhDang_83_Hoang.csv";

            // Đóng cửa sổ cmd
            chrome_83_Hoang = ChromeDriverService.CreateDefaultService();
            chrome_83_Hoang.HideCommandPromptWindow = true;

            // Link web để thực hiện kiểm thử chức năng tìm kiếm
            String link_web_login_83_Hoang = "https://enka.network/accounts/login/";

            // Khởi tạo Driver cho trang web và dẫn đến trang web
            driver_83_Hoang = new ChromeDriver(chrome_83_Hoang);
            driver_83_Hoang.Navigate().GoToUrl(link_web_login_83_Hoang);

            // Kiểm tra xem file có tồn tại không trước khi đọc
            if (File.Exists(filePath_83_Hoang))
            {
                // Đọc tất cả các dòng từ file CSV
                var lines_83_Hoang = File.ReadAllLines(filePath_83_Hoang);

                // Bỏ qua dòng đầu tiên (tiêu đề) và xử lý từ dòng thứ hai
                for (int i = 1; i < lines_83_Hoang.Length; i++)
                {
                    string[] fields_83_Hoang = lines_83_Hoang[i].Split(',');

                    if (fields_83_Hoang.Length == 2)  // Đảm bảo mỗi dòng có 2 phần tử
                    {
                        // Lấy và làm sạch email
                        string email_83_Hoang = fields_83_Hoang[0].Trim();

                        // Lấy Element ô email bằng CssSelector
                        driver_83_Hoang.FindElement(By.CssSelector("input[type='email']")).SendKeys(email_83_Hoang);

                        // Nghỉ 2 giây
                        Thread.Sleep(2000);

                        // Lấy và làm sạch password
                        string password_83_Hoang = fields_83_Hoang[1].Trim();

                        // Lấy Element ô password bằng Name
                        driver_83_Hoang.FindElement(By.Name("password")).SendKeys(password_83_Hoang);

                        // Nghỉ 2 giây
                        Thread.Sleep(2000);

                        // Lấy Element nút đăng nhập bằng ClassName
                        driver_83_Hoang.FindElement(By.ClassName("submit")).Click();
                    }
                    // Nghỉ 5 giây
                    Thread.Sleep(5000);
                }
                // Thoát khỏi trang web
                driver_83_Hoang.Close();
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
