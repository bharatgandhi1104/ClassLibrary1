namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Resources;
    using System.Text;
    using System.Threading.Tasks;
    using Bogus;
    using NUnit.Framework;
    using Objectivity.Test.Automation.Common;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
#pragma warning disable SA1208 // System using directives should be placed before other using directives
    using System.Runtime;
#pragma warning restore SA1208 // System using directives should be placed before other using directives
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class DevsimStepDefinition : UIBaseStepDefinition
    {
        public object Client { get; private set; }


        [StepDefinition(@"I am a ""(.*)"" user")]
        public void GivenIAmAUser(string login_page)
        {
            Console.WriteLine("111");
            //this.ScenarioContext[login_page]= "https://devsim-ui-wa.azurewebsites.net/";
            //Console.WriteLine("122211" + this.ScenarioContext.Get<string>(login_page));
            Console.WriteLine(this.DriverContext.Driver);
#pragma warning disable CA2234 // Pass system uri objects instead of strings
            this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/");
#pragma warning restore CA2234 // Pass system uri objects instead of strings
            Console.WriteLine("Title:" + this.DriverContext.Driver.Title);

            // this.Get<Executors.UI.Common.ElementPage>().WaitUntilPageLoad();
        }

        [StepDefinition(@"I click on ""(.*)"" Radio Button")]
        public void IClickOnRadioButton(string mode_btn_value)
        {
            Console.WriteLine("mode_btn_value" + mode_btn_value);
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[1]/input")).Click();

            // this.Get<Executors.UI.Common.ElementPage>().WaitUntilPageLoad();
        }

        [StepDefinition(@"I enter the username into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterTheUsernameIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var userName = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[3]/input"));
            Console.WriteLine("page" + pageName);
            userName.Clear();
            userName.SendKeys("User1");
        }

        [StepDefinition(@"I enter the password into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterThePasswordIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var password = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[4]/input"));
            Console.WriteLine("page" + pageName);
            password.Clear();
            password.SendKeys("User1@123");
        }

        [StepDefinition(@"I get a response with a success status code (.*)")]
        public void ThenIGetAResponseWithASuccessStatusCode(int statusCode)
        {
            Console.WriteLine(statusCode);
            Console.WriteLine("Connection is established successfully");
        }

        [StepDefinition(@"I get a response with a status code (.*) with an exception")]
        public void ThenIGetAResponseWithAStatusCodeWithAnException(int statusCode)
        {
            Console.WriteLine(statusCode);
            Console.WriteLine("Connection cannot be established. An error has occured.");
        }

        [StepDefinition(@"I click on ""(.*)"" button simulator")]
        public void ThenIClickOnButtonSimulator(string buttonName)
        {
            this.ClickElementByText(buttonName, "Button");
            System.Threading.Thread.Sleep(10000);
        }

        [StepDefinition(@"I navigate to the ""(.*)"" page if the username and password are valid")]
        public void ThenINavigateToThePageIfTheUsernameAndPasswordAreValid(string dhudetails_page)
        {
            Console.WriteLine("1");
            //this.ScenarioContext[dhudetails_page] = "https://devsim-ui-wa.azurewebsites.net/SelectEnvironment";
#pragma warning disable CA2234 // Pass system uri objects instead of strings
            this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/SelectEnvironment");
#pragma warning restore CA2234 // Pass system uri objects instead of strings
            System.Threading.Thread.Sleep(2000);

            // this.Get<Executors.UI.Common.ElementPage>().WaitUntilPageLoad();
        }

        [StepDefinition(@"I verify that ""(.*)"" is pre-selected for Environment")]
        public void ThenIVerifyThatIsPre_SelectedForEnvironment(string radbtnName)
        {
            var azuredevBtn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[1]/input"));
            Console.WriteLine("ad:" + azuredevBtn);
            if (azuredevBtn.Text == radbtnName)
            {
                Console.WriteLine("Azure DEV present");
                if (azuredevBtn.GetAttribute("checked") == "True")
                {
                    Console.WriteLine("Azure DEV checkbox clicked");
                }
                else
                {
                    azuredevBtn.Click();
                    Console.WriteLine("Now clicked");
                }
            }
        }

        [StepDefinition(@"I verify that ""(.*)"" is pre-selected for DHU")]
        public void ThenIVerifyThatIsPre_SelectedForDHU(string radbtnName)
        {
            var selectexistingLabel = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/label"));
            var selectexistingBtn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/input"));
            Console.WriteLine("se:" + selectexistingBtn);
            if (selectexistingLabel.Text == radbtnName)
            {
                Console.WriteLine("Select Existing present");
                if (selectexistingBtn.GetAttribute("checked") == "True")
                {
                    Console.WriteLine("Select Existing checkbox clicked");
                }
                else
                {
                    selectexistingBtn.Click();
                    Console.WriteLine("Now clicked");
                }
            }
        }

        [StepDefinition(@"I click on the ""(.*)"" button")]
        public void ThenIClickOnTheButton(string logout_btn)
        {
            if (this.DriverContext.Driver.Url == "https://devsim-ui-wa.azurewebsites.net/SelectEnvironment")
            {
                Console.WriteLine(logout_btn);
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/header/nav/div[3]")).Click();
                Console.WriteLine("Logout Button is clicked.");
            }
            else if (this.DriverContext.Driver.Url == "https://devsim-ui-wa.azurewebsites.net/AddDevice")
            {
                Console.WriteLine(logout_btn);
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/header/nav/div[3]")).Click();
                Console.WriteLine("Logout Button is clicked.");
            }
            else if (this.DriverContext.Driver.Url == "https://devsim-ui-wa.azurewebsites.net/SelectDevice")
            {
                Console.WriteLine(logout_btn);
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id=root']/div/header/nav/div[3]")).Click();
                Console.WriteLine("Logout Button is clicked.");
            }
        }

        [StepDefinition(@"I am logged out from the application")]
        public void ThenIAmLoggedOutFromTheApplication()
        {
            this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Logout is done.");
        }

        [StepDefinition(@"I enter an invalid username into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterAnInvalidUsernameIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var userName = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[3]/input"));
            Console.WriteLine("page" + pageName);
            userName.Clear();
            userName.SendKeys("User123");
        }

        [StepDefinition(@"I enter a valid password into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterAValidPasswordIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var password = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[4]/input"));
            Console.WriteLine("page" + pageName);
            password.Clear();
            password.SendKeys("User1@123");
        }

        [StepDefinition(@"I enter a valid username into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterAValidUsernameIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var userName = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[3]/input"));
            Console.WriteLine("page" + pageName);
            userName.Clear();
            userName.SendKeys("User1");
        }

        [StepDefinition(@"I enter an invalid password into ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterAnInvalidPasswordIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var password = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[4]/input"));
            Console.WriteLine("page" + pageName);
            password.Clear();
            password.SendKeys("User1@1234213");
        }

        [StepDefinition(@"I see that I am not able to login")]
        public void ThenISeeThatIAmNotAbleToLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"I see an ""(.*)"" error text appearing")]
        public void ThenISeeAnErrorTextAppearing(string errorName)
        {
            if (this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[1]/h3")).Displayed)
            {
                Console.WriteLine("Error Message is displayed. Either the username or password is invalid!!");
            }
            else
            {
                Console.WriteLine("There is something wrong!!");
            }
        }

        [StepDefinition(@"I enter blank value into ""(.*)"" text field in the ""(.*)"" page")]
        public void IEnterBlankValueIntoTextFieldInThePage(string fieldName, string pageName)
        {
            Console.WriteLine("name" + fieldName);
            var userName = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[3]/input"));
            Console.WriteLine("page" + pageName);
            userName.Clear();
            userName.SendKeys(" ");
        }

        [StepDefinition(@"I press ""(.*)"" button on the keyboard")]
        public void ThenIPressButtonOnTheKeyboard(string buttonName)
        {
            Console.WriteLine("Enter button is clicked" + buttonName);
            var login_btn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[5]/button"));

            // login_btn.Clear();
            Console.WriteLine("Clear is there!");
            login_btn.SendKeys(Keys.Enter);
        }

        [StepDefinition(@"I click on ""(.*)"" mode Radio Button")]
        public void GivenIClickOnModeRadioButton(string mode_btn_value)
        {
            Console.WriteLine("mode_btn_value" + mode_btn_value);
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/input")).Click();
        }

        [StepDefinition(@"I am navigated to the ""(.*)"" page of the application")]
        public void ThenIAmNavigatedToThePageOfTheApplication(string pageName)
        {
            Console.WriteLine(pageName);
            if (pageName == "DHU Details")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/SelectEnvironment/");
                System.Threading.Thread.Sleep(10000);
            }
            else if (pageName == "C2D")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/CloudToDeviceMessage");
                System.Threading.Thread.Sleep(10000);
            }
            else if (pageName == "Add New")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/AddDevice");
                System.Threading.Thread.Sleep(10000);
            }
            else if (pageName == "Existing DHU")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/SelectDevice/?env=Dev");
                System.Threading.Thread.Sleep(5000);
            }
            else if (pageName == "Landing")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/DeviceDetails/General/?DeviceID=Dev_9000789");
                System.Threading.Thread.Sleep(10000);
            }
            else if (pageName == "Edit Device")
            {
                this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/EditDevice");
                System.Threading.Thread.Sleep(7000);
            }
        }

        [StepDefinition(@"I select the first available device from the list")]
        public void ThenISelectTheFirstAvailableDeviceFromTheList()
        {
            var radbtn1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']"));
            var radbtn2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']"));
            var radbtn3 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']"));
            var radbtn4 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']"));
            var radbtn5 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']"));
            if (radbtn1.Enabled)
            {
                Console.WriteLine("89 button is enabled");
                radbtn1.Click();
            }
            else
            {
                if (radbtn2.Enabled)
                {
                    Console.WriteLine("90 button is enabled");
                    radbtn2.Click();
                }
                else
                {
                    if (radbtn3.Enabled)
                    {
                        Console.WriteLine("91 button is enabled");
                        radbtn3.Click();
                    }
                    else
                    {
                        if (radbtn4.Enabled)
                        {
                            Console.WriteLine("92 button is enabled");
                            radbtn4.Click();
                        }
                        else
                        {
                            if (radbtn5.Enabled)
                            {
                                Console.WriteLine("93 button is enabled");
                                radbtn5.Click();
                            }
                            else
                            {
                                Console.WriteLine("No device is enabled");
                            }
                        }
                    }
                }
            }
        }

        [StepDefinition(@"I verify whether the device is the same as selected before")]
        public void ThenIVerifyWhetherTheDeviceIsTheSameAsSelectedBefore()
        {
            var deviceId = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div/div[1]/div[2]")).Text;
            if (deviceId == "9000789")
            {
                Console.WriteLine("789 device is selected");
            }
            else if (deviceId == "9000790")
            {
                Console.WriteLine("790 device is selected");
            }
            else if (deviceId == "9000791")
            {
                Console.WriteLine("791 device is selected");
            }
            else if (deviceId == "9000792")
            {
                Console.WriteLine("792 device is selected");
            }
            else if (deviceId == "9000793")
            {
                Console.WriteLine("793 device is selected");
            }
            else
            {
                Console.WriteLine("Some wrong device is selected");
            }
        }

        [StepDefinition(@"I edit the value of ""(.*)"" to ""(.*)""")]
        public void ThenIEditTheValueOfTo(string fieldName, string editedValue)
        {
            Console.WriteLine(fieldName);
            var versionNumberField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[5]/input"));
            versionNumberField.Clear();
            versionNumberField.SendKeys(editedValue);
        }

        [StepDefinition(@"I select any other device from the given list")]
        public void ThenISelectAnyOtherDeviceFromTheGivenList()
        {
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div[3]/table/tbody/tr[2]/td[2]")).Click();
            Console.WriteLine("Another option is selected.");
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div[4]/a[2]/button")).Click();
        }

        [StepDefinition(@"I am navigated back to the ""(.*)"" page again")]
        public void ThenIAmNavigatedBackToThePageAgain(string pageName)
        {
            this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/DeviceDetails/General/?DeviceID=Dev_9000789");
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I see that the following tabs are present on the ""(.*)"" page")]
        public void ThenISeeThatTheFollowingTabsArePresentOnThePage(string pageName, Table table)
        {
            Console.WriteLine(pageName);
            Console.WriteLine("1********:" + table.RowCount);
            List<string> tabName = table.CreateSet<KeyValue>().Select(x => x.Key).ToList();
            Console.WriteLine(tabName[0]);
            var generalTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[1]")).Text;
            Console.WriteLine(generalTab);
            if (generalTab == tabName[0])
            {
                Console.WriteLine("General tab found");
            }
            else
            {
                Console.WriteLine("General tab not found");
            }

            Console.WriteLine(tabName[1]);
            var checklistsTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[2]")).Text;
            Console.WriteLine(checklistsTab);
            if (checklistsTab == tabName[1])
            {
                Console.WriteLine("Checklists tab found");
            }
            else
            {
                Console.WriteLine("Checklists tab not found");
            }

            Console.WriteLine(tabName[2]);
            var impactTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[3]")).Text;
            Console.WriteLine(impactTab);
            if (impactTab == tabName[2])
            {
                Console.WriteLine("Impact Management tab found");
            }
            else
            {
                Console.WriteLine("Impact Management tab not found");
            }

            Console.WriteLine(tabName[3]);
            var locationTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[4]")).Text;
            Console.WriteLine(locationTab);
            if (locationTab == tabName[3])
            {
                Console.WriteLine("Location Services tab found");
            }
            else
            {
                Console.WriteLine("Location Services tab not found");
            }

            Console.WriteLine(tabName[4]);
            var accessControlTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[5]")).Text;
            Console.WriteLine(accessControlTab);
            if (accessControlTab == tabName[4])
            {
                Console.WriteLine("Access Control tab found");
            }
            else
            {
                Console.WriteLine("Access Control tab not found");
            }

            Console.WriteLine(tabName[5]);
            var vehLockoutTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[6]")).Text;
            Console.WriteLine(vehLockoutTab);
            if (vehLockoutTab == tabName[5])
            {
                Console.WriteLine("Vehicle Lockout/Release tab found");
            }
            else
            {
                Console.WriteLine("Vehicle Lockout/Release tab not found");
            }

            Console.WriteLine(tabName[6]);
            var vehErrorTab = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[7]")).Text;
            Console.WriteLine(vehErrorTab);
            if (vehErrorTab == tabName[6])
            {
                Console.WriteLine("Vehicle Errors tab found");
            }
            else
            {
                Console.WriteLine("Vehicle Errors tab not found");
            }
        }

        [StepDefinition(@"I check that the device selected is not connected by default by checking the ""(.*)"" button")]
        public void ThenICheckThatTheDeviceSelectedIsNotConnectedByDefaultByCheckingTheButton(string btn_content)
        {
            var connectdhuBtn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div/div[3]/div/button[2]/span")).Text;
            if (connectdhuBtn == btn_content)
            {
                Console.WriteLine("Device is not connected by default");
            }
            else
            {
                Console.WriteLine("There is something wrong");
            }
        }

        [StepDefinition(@"I click on ""(.*)"" button symbol")]
        public void ThenIClickOnButtonSymbol(string btn_name)
        {
            var connectDhuBtn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div/div[3]/div/button[2]/span")).Text;

            if (connectDhuBtn == btn_name)
            {
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/div/div[3]/div/button[2]/span")).Click();
                Console.WriteLine("Button is clicked!");
                System.Threading.Thread.Sleep(5000);
            }
        }

        [StepDefinition(@"I check the log message generated after connecting the device in the ""(.*)"" window")]
        public void ThenICheckTheLogMessageGeneratedAfterConnectingTheDeviceInTheWindow(string windowName)
        {
            Console.WriteLine(windowName);
            var logMsgLine1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[1]/span[2]"));
            var logMsgLine2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[2]/span[2]"));
            var logMsgLine3 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[3]/span[2]"));
            var logMsgLine4 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[4]/span[2]"));
            if (logMsgLine1.Text.Contains("connected successfully") || logMsgLine2.Text.Contains("connected successfully") || logMsgLine3.Text.Contains("connected successfully") || logMsgLine4.Text.Contains("connected successfully"))
            {
                Console.WriteLine("Log msg found");
            }
            else
            {
                Console.WriteLine("Device is not connected yet.");
            }
        }

        [StepDefinition(@"I move to the ""(.*)"" tab")]
        public void ThenIMoveToTheTab(string tabName)
        {
            var tabLabel = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='nav-menu']/div/div/div[1]/a[2]"));
            if (tabLabel.Text == tabName)
            {
                tabLabel.Click();
                Console.WriteLine("Checklists tab is clicked");
            }
            else
            {
                Console.WriteLine("There is some problem");
            }
        }

        [StepDefinition(@"I check all the fields present in that page are already filled or not")]
        public void ThenICheckAllTheFieldsPresentInThatPageAreAlreadyFilledOrNot()
        {
            var vehcommintField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[1]/input"));
            var opidField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[2]/input"));
            var hdopField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[3]/input"));
            var fixtypeField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[4]/input"));
            var numsatField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[4]/input"));
            var checklistidField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[6]/input"));
            var checklistcvField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[7]/input"));
            var checkliststatusField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[8]/select"));
            var checklistqidField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[8]/select"));
            var checklistansField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[10]/input"));
            var checklistdurField = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/form/div[11]/input"));
            if (vehcommintField.Displayed && opidField.Displayed && hdopField.Displayed && fixtypeField.Displayed && numsatField.Displayed && checklistidField.Displayed && checklistcvField.Displayed && checkliststatusField.Displayed && checklistqidField.Displayed && checklistansField.Displayed && checklistdurField.Displayed)
            {
                Console.WriteLine("All the fields are present");
            }
            else
            {
                Console.WriteLine("There is some problem.");
            }
        }

        [StepDefinition(@"I click on the ""(.*)"" button on that page")]
        public void ThenIClickOnTheButtonOnThatPage(string btnName)
        {
            var sendBtn = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[3]/div/div/div/div/div/button/span"));
            if (sendBtn.Text == btnName)
            {
                sendBtn.Click();
                Console.WriteLine("Send Button is clicked");
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Send button could not be clicked");
            }
        }

        [StepDefinition(@"I verify the logs whether the message is sent successfully or not")]
        public void ThenIVerifyTheLogsWhetherTheMessageIsSentSuccessfullyOrNot()
        {
            var logResultline1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[1]/span[2]"));
            var logResultline2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[2]/span[2]"));
            var logResultline3 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[3]/span[2]"));
            var logResultline4 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='logs-div']/div[4]/span[2]"));
            if (logResultline1.Text.Contains("sent checklist result payload successfully") || logResultline2.Text.Contains("sent checklist result payload successfully") || logResultline3.Text.Contains("sent checklist result payload successfully") || logResultline4.Text.Contains("sent checklist result payload successfully"))
            {
                Console.WriteLine("Checklist Message is sent successfully.");
            }
            else
            {
                Console.WriteLine("Message is not sent");
            }
        }

        [StepDefinition(@"I select any of the available device from the list")]
        public void ThenISelectAnyOfTheAvailableDeviceFromTheList()
        {
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='inlineRadio1']")).Click();
            System.Threading.Thread.Sleep(10000);
        }

        [StepDefinition(@"I select the ""(.*)"" option for ""(.*)""")]
        public void ThenISelectTheOptionFor(string optName, string tabName)
        {
            Console.WriteLine(optName);
            Console.WriteLine(tabName);
            this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[1]/input")).Click();
        }

        [StepDefinition(@"I select the ""(.*)"" option for ""(.*)"" to add a new device")]
        public void ThenISelectTheOptionForToAddANewDevice(string optName, string tabName)
        {
            Console.WriteLine(optName);
            Console.WriteLine(tabName);
            if (optName == "Add New")
            {
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[1]/input")).Click();
            }
            else if (optName == "Select Existing")
            {
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/input")).Click();
            }
        }

        [StepDefinition(@"I select the ""(.*)"" option for ""(.*)"" to select an existing device")]
        public void ThenISelectTheOptionForToSelectAnExistingDevice(string optName, string tabName)
        {
            Console.WriteLine(optName);
            Console.WriteLine(tabName);
            if (optName == "Add New")
            {
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[1]/input")).Click();
            }
            else if (optName == "Select Existing")
            {
                this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/input")).Click();
            }
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field in the ""(.*)"" page")]
        public void ThenIEnterInTextFieldInThePage(string text_val, string fieldName, string pageName)
        {
            Console.WriteLine(pageName);
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field vi")]
        public void ThenIEnterInTextFieldVi(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field vs")]
        public void ThenIEnterInTextFieldVs(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[3]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field vm")]
        public void ThenIEnterInTextFieldVm(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[4]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field vn")]
        public void ThenIEnterInTextFieldVn(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[5]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I select ""(.*)"" option from the ""(.*)"" dropdown list pv")]
        public void ThenISelectOptionFromTheDropdownListPv(string dd_value, string fieldName)
        {
            Console.WriteLine(dd_value);
            Console.WriteLine(fieldName);
            var dropDown = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[6]/select"));
            new SelectElement(dropDown).SelectByIndex(0);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field ma")]
        public void ThenIEnterInTextFieldMa(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[7]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I select ""(.*)"" option from the ""(.*)"" dropdown list ca")]
        public void ThenISelectOptionFromTheDropdownListCa(string dd_value, string fieldName)
        {
            Console.WriteLine(dd_value);
            Console.WriteLine(fieldName);
            var dropDown = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[8]/select"));
            new SelectElement(dropDown).SelectByIndex(0);
        }

        [StepDefinition(@"I select ""(.*)"" option from the ""(.*)"" dropdown list fw")]
        public void ThenISelectOptionFromTheDropdownListFw(string dd_value, string fieldName)
        {
            Console.WriteLine(dd_value);
            Console.WriteLine(fieldName);
            var dropDown = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[9]/select"));
            new SelectElement(dropDown).SelectByIndex(0);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field si")]
        public void ThenIEnterInTextFieldSi(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[10]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field lat")]
        public void ThenIEnterInTextFieldLat(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[11]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"I enter ""(.*)"" in ""(.*)"" text field long")]
        public void ThenIEnterInTextFieldLong(string text_val, string fieldName)
        {
            Console.WriteLine(fieldName);
            var field = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[12]/input"));
            field.SendKeys(text_val);
            System.Threading.Thread.Sleep(5000);
        }

        [StepDefinition(@"the device is saved successfully and added to the list of existing device")]
        public void ThenTheDeviceIsSavedSuccessfullyAndAddedToTheListOfExistingDevice()
        {
            Console.WriteLine("1");
#pragma warning disable CA2234 // Pass system uri objects instead of strings
            this.DriverContext.Driver.Navigate().GoToUrl("https://devsim-ui-wa.azurewebsites.net/SelectDevice");
#pragma warning restore CA2234 // Pass system uri objects instead of strings
            System.Threading.Thread.Sleep(2000);
        }

        [StepDefinition(@"I see the following options for ""(.*)"" in the ""(.*)"" page")]
        public void ThenISeeTheFollowingOptionsForInThePage(string tabName, string pageName, Table table)
        {
            Console.WriteLine(tabName);
            Console.WriteLine(pageName);
            if (tabName == "Environment")
            {
                Console.WriteLine("1********:" + table.RowCount);
                List<string> environmentType = table.CreateSet<KeyValue>().Select(x => x.Key).ToList();
                Console.WriteLine(environmentType[0]);
                var environment1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[1]/label")).Text;
                Console.WriteLine(environment1);
                if (environment1 == environmentType[0])
                {
                    Console.WriteLine("Azure Dev environment found");
                }
                else
                {
                    Console.WriteLine("AD env not found");
                }

                var environment2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[2]/label")).Text;
                Console.WriteLine(environment2);
                if (environment2 == environmentType[1])
                {
                    Console.WriteLine("Azure Qa environment found");
                }
                else
                {
                    Console.WriteLine("AQ env not found");
                }

                var environment3 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[3]/label")).Text;
                Console.WriteLine(environment3);
                if (environment3 == environmentType[2])
                {
                    Console.WriteLine("Azure Uat environment found");
                }
                else
                {
                    Console.WriteLine("AU env not found");
                }
            }
            else if (tabName == "DHU")
            {
                Console.WriteLine("1********:" + table.RowCount);
                List<string> dhuType = table.CreateSet<KeyValue>().Select(x => x.Key).ToList();
                var dhu_opt1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[1]/label")).Text;
                if (dhu_opt1 == dhuType[0])
                {
                    Console.WriteLine("Add New Label is found in the page");
                }
                else
                {
                    Console.WriteLine("No Add New Label Found");
                }

                var dhu_opt2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/label")).Text;
                if (dhu_opt2 == dhuType[1])
                {
                    Console.WriteLine("Existing Device Label is found in the page");
                }
                else
                {
                    Console.WriteLine("No Existing Device Label Found");
                }
            }

            System.Threading.Thread.Sleep(10000);
        }

        [StepDefinition(@"I am able to click on any of the present radio buttons for ""(.*)""")]
        public void ThenIAmAbleToClickOnAnyOfThePresentRadioButtonsFor(string tabName)
        {
            Console.WriteLine(tabName);
            if (tabName == "Environment")
            {
                var rbtn1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[1]/input"));
                var rbtn2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[1]/input"));
                var rbtn3 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[1]/div[3]/input"));
                IWebElement[] radbtnarr = { rbtn1, rbtn2, rbtn3 };
                for (int i = 0; i < radbtnarr.Length; i++)
                {
                    radbtnarr[i].Click();
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(5000);
                }
            }
            else if (tabName == "DHU")
            {
                var rbtn1 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[1]/input"));
                var rbtn2 = this.DriverContext.Driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div[2]/form/div[2]/div[2]/input"));
                IWebElement[] radbtnarr = { rbtn1, rbtn2 };
                for (int i = 0; i < radbtnarr.Length; i++)
                {
                    radbtnarr[i].Click();
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

    }
}
