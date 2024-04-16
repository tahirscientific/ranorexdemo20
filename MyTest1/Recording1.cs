﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("55f6e1fd-34b8-4aee-8072-a0eca619369d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MotDePasse.Password' at 42;9.", repo.MotDePasse.PasswordInfo, new RecordItemIndex(0));
            repo.MotDePasse.Password.Click("42;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}123456{LShiftKey up}' with focus on 'MotDePasse.Password'.", repo.MotDePasse.PasswordInfo, new RecordItemIndex(1));
            repo.MotDePasse.Password.PressKeys("{LShiftKey down}123456{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MotDePasse.ButtonOK' at 55;16.", repo.MotDePasse.ButtonOKInfo, new RecordItemIndex(2));
            repo.MotDePasse.ButtonOK.Click("55;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SetupOCM' at 49;52.", repo.SetupOCM.SelfInfo, new RecordItemIndex(3));
            repo.SetupOCM.Self.Click("49;52");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SettingsOcm.Configuration' at 69;13.", repo.SettingsOcm.ConfigurationInfo, new RecordItemIndex(4));
            repo.SettingsOcm.Configuration.Click("69;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SetupOCM.Fermer' at 49;12.", repo.SetupOCM.FermerInfo, new RecordItemIndex(5));
            repo.SetupOCM.Fermer.Click("49;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SetupOCM' at 27;48.", repo.SetupOCM.SelfInfo, new RecordItemIndex(6));
            repo.SetupOCM.Self.Click("27;48");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SettingsOcm.Quitter' at 146;11.", repo.SettingsOcm.QuitterInfo, new RecordItemIndex(7));
            repo.SettingsOcm.Quitter.Click("146;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Confirm.ButtonYes' at 28;15.", repo.Confirm.ButtonYesInfo, new RecordItemIndex(8));
            repo.Confirm.ButtonYes.Click("28;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
