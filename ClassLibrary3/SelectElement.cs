using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace OpenQA.Selenium.Support.UI
{
    public class SelectElement : IWrapsElement
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern SelectElement(IWebElement element);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the OpenQA.Selenium.IWebElement wrapped by this object.
        public IWebElement WrappedElement { get; }
        //
        // Summary:
        //     Gets a value indicating whether the parent element supports multiple selections.
        public bool IsMultiple { get; }
        //
        // Summary:
        //     Gets the list of options for the select element.
        public IList<IWebElement> Options { get; }
        //
        // Summary:
        //     Gets the selected item within the select element.
        //
        // Exceptions:
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown if no option is selected.
        //
        // Remarks:
        //     If more than one item is selected this will return the first item.
        public IWebElement SelectedOption { get; }
        //
        // Summary:
        //     Gets all of the selected options within the select element.
        public IList<IWebElement> AllSelectedOptions { get; }


        //
        // Summary:
        //     Clear all selected entries. This is only valid when the SELECT supports multiple
        //     selections.
        //
        // Exceptions:
        //   T:OpenQA.Selenium.WebDriverException:
        //     Thrown when attempting to deselect all options from a SELECT that does not support
        //     multiple selections.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void DeselectAll();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Deselect the option by the index, as determined by the "index" attribute of the
        //     element.
        //
        // Parameters:
        //   index:
        //     The value of the index attribute of the option to deselect.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     Thrown when attempting to deselect option from a SELECT that does not support
        //     multiple selections.
        //
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown when no element exists with the specified index attribute.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void DeselectByIndex(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Deselect the option by the text displayed.
        //
        // Parameters:
        //   text:
        //     The text of the option to be deselected.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     Thrown when attempting to deselect option from a SELECT that does not support
        //     multiple selections.
        //
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown when no element exists with the specified test attribute.
        //
        // Remarks:
        //     When given "Bar" this method would deselect an option like:
        //     <option value="foo">Bar</option>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void DeselectByText(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Deselect the option having value matching the specified text.
        //
        // Parameters:
        //   value:
        //     The value of the option to deselect.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     Thrown when attempting to deselect option from a SELECT that does not support
        //     multiple selections.
        //
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown when no element exists with the specified value attribute.
        //
        // Remarks:
        //     When given "foo" this method will deselect an option like:
        //     <option value="foo">Bar</option>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void DeselectByValue(string value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Select the option by the index, as determined by the "index" attribute of the
        //     element.
        //
        // Parameters:
        //   index:
        //     The value of the index attribute of the option to be selected.
        //
        // Exceptions:
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown when no element exists with the specified index attribute.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SelectByIndex(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Select all options by the text displayed.
        //
        // Parameters:
        //   text:
        //     The text of the option to be selected.
        //
        //   partialMatch:
        //     Default value is false. If true a partial match on the Options list will be performed,
        //     otherwise exact match.
        //
        // Exceptions:
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown if there is no element with the given text present.
        //
        // Remarks:
        //     When given "Bar" this method would select an option like:
        //     <option value="foo">Bar</option>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SelectByText(string text, bool partialMatch = false);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Select an option by the value.
        //
        // Parameters:
        //   value:
        //     The value of the option to be selected.
        //
        // Exceptions:
        //   T:OpenQA.Selenium.NoSuchElementException:
        //     Thrown when no element with the specified value is found.
        //
        // Remarks:
        //     When given "foo" this method will select an option like:
        //     <option value="foo">Bar</option>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SelectByValue(string value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}