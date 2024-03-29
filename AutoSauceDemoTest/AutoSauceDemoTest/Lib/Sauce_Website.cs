﻿using Sauce_TestAutomationFramework.Lib.DriverConfig;
using AutoSauceDemoTest.Lib.Pages;
using OpenQA.Selenium;

namespace Sauce_TestAutomationFramework.Lib;

// Super class - essentially acting as a service object for all pages
// i.e. decomposes objects into manageable classes and methods
public class Sauce_Website<T> where T : IWebDriver, new()
{
    #region Accessible age Objects and Selenium Driver
    public IWebDriver SeleniumDriver { get; set; }
    public Sauce_HomePage Sauce_HomePage { get; set; }
    public Sauce_ProductsPage Sauce_ProductsPage { get; set; }
    public Sauce_CartPage Sauce_CartPage { get; set; }
    public Sauce_CheckoutPage1 Sauce_CheckoutPage1 { get; set; }
    public Sauce_CheckoutPage2 Sauce_CheckoutPage2 { get; set; }
    #endregion

    //Constructor for driver and config for teh service
    public Sauce_Website(int pageLoadInsecs = 10, int implicitWaitInSecs = 10, bool isHeadless = false)
    {
        //instatiate the driver
        SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInSecs, isHeadless).Driver;
        //instatiate our page objects with the selenium driver
        Sauce_HomePage = new Sauce_HomePage(SeleniumDriver);
        Sauce_ProductsPage = new Sauce_ProductsPage(SeleniumDriver);
        Sauce_CartPage = new Sauce_CartPage(SeleniumDriver);
        Sauce_CheckoutPage1 = new Sauce_CheckoutPage1(SeleniumDriver);
        Sauce_CheckoutPage2 = new Sauce_CheckoutPage2(SeleniumDriver);
    }
}
