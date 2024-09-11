using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace BTL_KTPM_UnitTest_Enka.Network_83_Hoang
{
    [TestClass]
    public class UnitTest1
    {
        // Khởi tạo TestContext để thực hiện đọc file csv
        public TestContext TestContext { get; set; }

        private static ChromeDriverService chrome_83_Hoang;

        private static IWebDriver driver_83_Hoang;

        //// Đọc file csv của chức năng tìm kiếm
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    "E:\\MY_STUDY\\CODE\\C#\\BTL_KTPM_83_Hoang\\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\\BTL_KTPM_UnitTest_Enka.Network_83_Hoang\\Data\\TestData_TimKiem_83_Hoang.csv",
        //    "TestData_TimKiem_83_Hoang#csv",
        //    DataAccessMethod.Sequential
        //    )]

        //// Tất cả Test Case của chức năng tìm kiếm người chơi
        //[TestMethod]
        //public void TestMethod_TimKiem_83_Hoang()
        //{
        //    // Đóng cửa sổ cmd
        //    chrome_83_Hoang = ChromeDriverService.CreateDefaultService();
        //    chrome_83_Hoang.HideCommandPromptWindow = true;

        //    // Link web để thực hiện kiểm thử chức năng tìm kiếm
        //    String link_web_search_83_Hoang = "https://enka.network/";

        //    // Khởi tạo Driver cho trang web và dẫn đến trang web
        //    driver_83_Hoang = new ChromeDriver(chrome_83_Hoang);
        //    driver_83_Hoang.Navigate().GoToUrl(link_web_search_83_Hoang);

        //    // Lấy các giá trị từ file csv
        //    string uid_83_Hoang = TestContext.DataRow[0].ToString();

        //    string game_83_Hoang = TestContext.DataRow[1].ToString();

        //    // Lấy Element ô tìm kiếm bằng ClassName
        //    driver_83_Hoang.FindElement(By.ClassName("uid")).SendKeys(uid_83_Hoang);

        //    // Nghỉ 2 giây
        //    Thread.Sleep(2000);

        //    // Lấy Element game bằng ClassName
        //    driver_83_Hoang.FindElement(By.ClassName(game_83_Hoang)).Click();

        //    // Nghỉ 2 giây
        //    Thread.Sleep(2000);

        //    // Lấy Element nút tìm kiếm bằng XPath
        //    driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[2]/div/button")).Click();

        //    // Nghỉ 10 giây
        //    Thread.Sleep(10000);

        //    try
        //    {
        //        // Kiểm tra sự xuất hiện của phần tử người chơi bằng XPath
        //        IWebElement nameElement_83_Hoang = driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[1]/div/div[1]/h1"));

        //        // Lấy nội dung của phần tử người chơi
        //        string actual_83_Hoang = nameElement_83_Hoang.Text;

        //        // So sánh với dữ liệu mong đợi
        //        if (actual_83_Hoang == TestContext.DataRow[2].ToString())
        //        {
        //            Console.WriteLine("Đã tìm thấy đúng người chơi");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Không tìm thấy đúng người chơi");
        //        }
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        // Nếu không tìm thấy phần tử người chơi, coi đây là trường hợp không tìm thấy người chơi
        //        Console.WriteLine("Không tìm thấy người chơi");
        //    }
        //    finally
        //    {
        //        // Đóng web
        //        driver_83_Hoang.Quit();
        //    }
        //}

        //// Đọc file csv của chức năng đăng nhập
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    @"E:\\MY_STUDY\\CODE\\C#\\BTL_KTPM_83_Hoang\\83_Hoang_N1_KiemThu_UnitTest_WebEnka.Network_API\\BTL_KTPM_UnitTest_Enka.Network_83_Hoang\\Data\\TestData_DangNhap_83_Hoang.csv",
        //    "TestData_DangNhap_83_Hoang#csv", DataAccessMethod.Sequential)]

        //// Tất cả Test Case của chức năng đăng nhập
        //[TestMethod]
        //public void TestMethod_DangNhap_83_Hoang()
        //{
        //    //Đóng cửa sổ cmd
        //    chrome_83_Hoang = ChromeDriverService.CreateDefaultService();
        //    chrome_83_Hoang.HideCommandPromptWindow = true;

        //    // Link web để thực hiện kiểm thử chức năng đăng nhập
        //    String link_web_login_83_Hoang = "https://enka.network/accounts/login/";

        //    // Khởi tạo Driver cho trang web và dẫn đến trang web
        //    driver_83_Hoang = new ChromeDriver(chrome_83_Hoang);
        //    driver_83_Hoang.Navigate().GoToUrl(link_web_login_83_Hoang);

        //    // Lấy các giá trị từ file csv
        //    string email_83_Hoang = TestContext.DataRow[0].ToString();

        //    string password_83_Hoang = TestContext.DataRow[1].ToString();

        //    // Lấy Element email bằng CssSelector
        //    driver_83_Hoang.FindElement(By.CssSelector("input[type='email']")).SendKeys(email_83_Hoang);

        //    // Nghỉ 2 giây
        //    Thread.Sleep(2000);

        //    // Lấy Element password bằng CssSelector
        //    if (password_83_Hoang == "")
        //        password_83_Hoang = "112233445566yane";
        //    driver_83_Hoang.FindElement(By.CssSelector("input[type='password']")).SendKeys(password_83_Hoang);

        //    // Nghỉ 2 giây
        //    Thread.Sleep(2000);

        //    // Lấy Element nút đăng nhập bằng XPath
        //    driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/div[2]/div/div[2]/div[1]/form/button")).Click();

        //    // Nghỉ 10 giây
        //    Thread.Sleep(10000);

        //    try
        //    {
        //        // Kiểm tra sự xuất hiện của phần tử người chơi bằng XPath
        //        IWebElement nameElement_83_Hoang = driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/div[2]/div[1]/div[1]/div/div[1]/h1/span"));

        //        // Lấy nội dung của phần tử người chơi
        //        string actual_83_Hoang = nameElement_83_Hoang.Text;

        //        // So sánh với dữ liệu mong đợi
        //        if (actual_83_Hoang != "")
        //        {
        //            Console.WriteLine("Đăng nhập thành công");
        //        }
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        // Email chưa được đăng ký hoặc sai password
        //        if (TestContext.DataRow[0].ToString().Contains("@"))
        //        {
        //            Console.WriteLine("Email chưa đăng ký hoặc password bị sai");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Email sai định dạng");
        //        }
        //    }
        //    finally
        //    {
        //        // Đóng web
        //        driver_83_Hoang.Quit();
        //    }
        //}

        [TestMethod]
        public void ABC_Test()
        {
            // Đóng cửa sổ cmd
            chrome_83_Hoang = ChromeDriverService.CreateDefaultService();
            chrome_83_Hoang.HideCommandPromptWindow = true;

            // Link web để thực hiện kiểm thử chức năng tìm kiếm
            String link_web_search_83_Hoang = "https://enka.network/";

            // Khởi tạo Driver cho trang web và dẫn đến trang web
            driver_83_Hoang = new ChromeDriver(chrome_83_Hoang);
            driver_83_Hoang.Navigate().GoToUrl(link_web_search_83_Hoang);

            // Lấy các giá trị từ file csv
            string uid_83_Hoang = "111";

            string game_83_Hoang = "gensher";

            // Lấy Element ô tìm kiếm bằng ClassName
            driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[2]/div/input")).SendKeys(uid_83_Hoang);

            // Nghỉ 2 giây
            Thread.Sleep(2000);

            // Lấy Element game bằng ClassName
            driver_83_Hoang.FindElement(By.ClassName(game_83_Hoang)).Click();

            // Nghỉ 2 giây
            Thread.Sleep(2000);

            // Lấy Element nút tìm kiếm bằng XPath
            driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[2]/div/button")).Click();

            // Nghỉ 10 giây
            Thread.Sleep(10000);

            try
            {
                // Kiểm tra sự xuất hiện của phần tử người chơi bằng XPath
                IWebElement nameElement_83_Hoang = driver_83_Hoang.FindElement(By.XPath("/html/body/div/main/content/div[1]/div/div[1]/h1"));

                // Lấy nội dung của phần tử người chơi
                string actual_83_Hoang = nameElement_83_Hoang.Text;

                // So sánh với dữ liệu mong đợi
                if (actual_83_Hoang == TestContext.DataRow[2].ToString())
                {
                    Console.WriteLine("Đã tìm thấy đúng người chơi");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy đúng người chơi");
                }
            }
            catch (NoSuchElementException)
            {
                // Nếu không tìm thấy phần tử người chơi, coi đây là trường hợp không tìm thấy người chơi
                Console.WriteLine("Không tìm thấy người chơi");
            }
            finally
            {
                // Đóng web
                driver_83_Hoang.Quit();
            }
        }
    }
}