﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject_DUMMY
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Dummy - Use 'DummyParams' to pass parameters into this method.
        /// </summary>
        public void Dummy()
        {

            // Go to web page 'about:blank' using new browser instance
            BrowserWindow browser = BrowserWindow.Launch(new System.Uri(this.DummyParams.Url));
        }
        
        #region Properties
        public virtual DummyParams DummyParams
        {
            get
            {
                if ((this.mDummyParams == null))
                {
                    this.mDummyParams = new DummyParams();
                }
                return this.mDummyParams;
            }
        }
        #endregion
        
        #region Fields
        private DummyParams mDummyParams;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Dummy'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class DummyParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'about:blank' using new browser instance
        /// </summary>
        public string Url = "about:blank";
        #endregion
    }
}
