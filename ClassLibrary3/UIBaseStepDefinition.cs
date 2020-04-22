namespace ClassLibrary3
{
    using System;
#pragma warning disable CS0436 // Type conflicts with imported type
    public class UIBaseStepDefinition : WebStepDefinitionBase, IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
        public UIBaseStepDefinition()
        {
        }

        ~UIBaseStepDefinition()
        {
            this.Dispose(false);
        }

        // public new UserCreds UserDetails => this.ScenarioContext.Get<UserCreds>(nameof(this.UserDetails));

        // ublic UserCreds InvitedUserDetails => this.ScenarioContext.Get<UserCreds>(nameof(this.InvitedUserDetails));

        // public RaymondSimulator RaymondSimulator { get; set; }

        // public ToyotaSimulator ToyotaSimulator { get; set; }

        //public string SiteId => this.ScenarioContext.ContainsKey("SiteId") ? this.ScenarioContext.Get<string>("SiteId") : this.Get<UrlPage>().EntityId;

        //public string ManufacturerId => this.UserDetails.Company.Equals("Toyota", StringComparison.OrdinalIgnoreCase) ? "1" : "2";

        public bool Disposed { get; private set; }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /*public async Task<List<dynamic>> GetLocalizationValues(LocalizedPage localizedPage, string resourceId, string localeId = null)
        {
            localizedPage.LocaleId = localeId ?? localizedPage.LocaleId;
            var localizationValues = (await this.ReadAllSqlAsync(SqlQueries.GetLocalizedValues, args: new { resourceId, localeId = localizedPage.LocaleId }).ConfigureAwait(false)).ToList();
            return localizationValues;
        }*/

        public void ClickPageButton(string buttonToClick, string page)
        {
            // this.Get<ElementPage>().WaitUntilElementToBeClickable($"Site_{page}_{buttonToClick}");
            buttonToClick = buttonToClick.Replace(" ", string.Empty);
            page = page.Replace(" ", string.Empty);
            // this.Get<ElementPage>().Click($"Site_{page}_{buttonToClick}");
        }

        public void ClickWizardButton(string text)
        {
            // this.ClickWizardElement(text, ElementTypes.Button);
        }

        public void ClickWizardLabel(string text)
        {
            // this.ClickWizardElement(text, ElementTypes.Label);
        }

        public void ClickOnMenu(string menu)
        {
            // this.ScenarioContext["Menu"] = menu;
            // var entityType = this.Get<UrlPage>().EntityType;
            // this.Get<ElementPage>().ClickMenu($"{entityType}_{menu}_Menu");
            // this.Get<ElementPage>().WaitUntilPageLoad();
        }

        public void OnPage(string title)
        {
            /* this.VerifyThat(() => Assert.IsTrue(
                this.Get<WindowPage>().HasPageTitle(title),
                $"Page Title Not as Expected {title}"));

            this.Get<ElementPage>().WaitUntilPageLoad();*/
        }

        /* public string FormId(bool localized, params string[] args)
        {
            // return this.Get<ElementPage>().CreateId(localized, args);
        }*/

        public void SearchForValueInTheGrid(string searchValue)
        {
            // this.Get<KendoGridPage>().SearchGrid(searchValue);
            // this.Get<ElementPage>().WaitUntilPageLoad();
            // this.ScenarioContext["SearchValue"] = searchValue;
        }

        public void ClickWizardSubmit(string text)
        {
            // this.ClickWizardElement(text, ElementTypes.Input);
        }

        protected void ClickWizardElement(string text, string type)
        {
            try
            {
                // this.Get<ElementPage>().ClickWizardElement(text, type); // TODO: Do we need to pass the wizard at all?
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                // Assert.Fail($"{text}: {ex.Message}");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    //this.RaymondSimulator?.Dispose();
                    //this.ToyotaSimulator?.Dispose();
                }

                this.Disposed = true;
            }
        }
    }
}