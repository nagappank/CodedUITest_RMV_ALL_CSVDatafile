using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUI_RMV_CSV_Data_ALL
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }
        
        //[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "D:\\Benutzer-Profile\\krishnanng\\Documents\\Visual Studio 2013\\Projects\\CodedUITestProject6\\DataCities.csv", "DataCities#csv", DataAccessMethod.Sequential), DeploymentItem("DataCities.csv"), TestMethod]
       // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "D:\\Benutzer-Profile\\krishnanng\\Documents\\Visual Studio 2013\\Projects\\CodedUITestProject6\\DataCities.XML", "Iterations", DataAccessMethod.Sequential), DeploymentItem("DataCities.XML"), TestMethod]
        public void CodedUITestMethod1()
        {

            
         
                // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
                this.UIMap.Launch_RMV();
                this.UIMap.LoginRMV();
                this.UIMap.SearchCity2(TestContext.DataRow["city_name"].ToString());
                this.UIMap.AssertSearchResult(TestContext.DataRow["city_name"].ToString());
                this.UIMap.LogoutAndCloseBrowser();


            System.Windows.Forms.MessageBox.Show("End");

        }
        


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
