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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("512797bc-f0b3-41d2-b77e-b4f49e2ae084")]
    public partial class MyTest1Repository : RepoGenBaseFolder
    {
        static MyTest1Repository instance = new MyTest1Repository();
        MyTest1RepositoryFolders.MotDePasseAppFolder _motdepasse;
        MyTest1RepositoryFolders.SetupOCMAppFolder _setupocm;
        MyTest1RepositoryFolders.SettingsOcmAppFolder _settingsocm;
        MyTest1RepositoryFolders.ConfirmAppFolder _confirm;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest1Repository element repository.
        /// </summary>
        [RepositoryFolder("512797bc-f0b3-41d2-b77e-b4f49e2ae084")]
        public static MyTest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest1Repository() 
            : base("MyTest1Repository", "/", null, 0, false, "512797bc-f0b3-41d2-b77e-b4f49e2ae084", ".\\RepositoryImages\\MyTest1Repository512797bc.rximgres")
        {
            _motdepasse = new MyTest1RepositoryFolders.MotDePasseAppFolder(this);
            _setupocm = new MyTest1RepositoryFolders.SetupOCMAppFolder(this);
            _settingsocm = new MyTest1RepositoryFolders.SettingsOcmAppFolder(this);
            _confirm = new MyTest1RepositoryFolders.ConfirmAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("512797bc-f0b3-41d2-b77e-b4f49e2ae084")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MotDePasse folder.
        /// </summary>
        [RepositoryFolder("72c847b8-3dc3-48e0-a429-108052fd2f73")]
        public virtual MyTest1RepositoryFolders.MotDePasseAppFolder MotDePasse
        {
            get { return _motdepasse; }
        }

        /// <summary>
        /// The SetupOCM folder.
        /// </summary>
        [RepositoryFolder("cb621981-f71f-41bd-a483-bded85a76c95")]
        public virtual MyTest1RepositoryFolders.SetupOCMAppFolder SetupOCM
        {
            get { return _setupocm; }
        }

        /// <summary>
        /// The SettingsOcm folder.
        /// </summary>
        [RepositoryFolder("9e42c05d-ce95-47b1-9bff-a85f23860457")]
        public virtual MyTest1RepositoryFolders.SettingsOcmAppFolder SettingsOcm
        {
            get { return _settingsocm; }
        }

        /// <summary>
        /// The Confirm folder.
        /// </summary>
        [RepositoryFolder("3c0c6e0d-7a18-4679-a9e2-f84e0de22953")]
        public virtual MyTest1RepositoryFolders.ConfirmAppFolder Confirm
        {
            get { return _confirm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest1RepositoryFolders
    {
        /// <summary>
        /// The MotDePasseAppFolder folder.
        /// </summary>
        [RepositoryFolder("72c847b8-3dc3-48e0-a429-108052fd2f73")]
        public partial class MotDePasseAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _passwordInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new MotDePasse  folder.
            /// </summary>
            public MotDePasseAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MotDePasse", "/form[@name='GetPassword']", parentFolder, 30000, null, true, "72c847b8-3dc3-48e0-a429-108052fd2f73", "")
            {
                _passwordInfo = new RepoItemInfo(this, "Password", "?/?/text[@name='Password']", "?/?/text[@name='Password']", 30000, null, "11001e27-5d6f-4112-8d89-da9434d490b6");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "?/?/button[@name='Btn_OK']", "?/?/button[@name='Btn_OK']", 30000, null, "a528b141-60c7-49a7-a1eb-a01c941ac7bf");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("72c847b8-3dc3-48e0-a429-108052fd2f73")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("72c847b8-3dc3-48e0-a429-108052fd2f73")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("11001e27-5d6f-4112-8d89-da9434d490b6")]
            public virtual Ranorex.Text Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("11001e27-5d6f-4112-8d89-da9434d490b6")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("a528b141-60c7-49a7-a1eb-a01c941ac7bf")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("a528b141-60c7-49a7-a1eb-a01c941ac7bf")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The SetupOCMAppFolder folder.
        /// </summary>
        [RepositoryFolder("cb621981-f71f-41bd-a483-bded85a76c95")]
        public partial class SetupOCMAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fermerInfo;

            /// <summary>
            /// Creates a new SetupOCM  folder.
            /// </summary>
            public SetupOCMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SetupOCM", "/form[@name='MainForm']", parentFolder, 30000, null, true, "cb621981-f71f-41bd-a483-bded85a76c95", "")
            {
                _fermerInfo = new RepoItemInfo(this, "Fermer", "form[@name='MccCfgDlg']/?/?/button[@name='btnOK']", ".//button[@name='btnOK']", 30000, null, "ef73c46e-08ce-407f-904c-c05cd646ddf2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cb621981-f71f-41bd-a483-bded85a76c95")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cb621981-f71f-41bd-a483-bded85a76c95")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Fermer item.
            /// </summary>
            [RepositoryItem("ef73c46e-08ce-407f-904c-c05cd646ddf2")]
            public virtual Ranorex.Button Fermer
            {
                get
                {
                    return _fermerInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Fermer item info.
            /// </summary>
            [RepositoryItemInfo("ef73c46e-08ce-407f-904c-c05cd646ddf2")]
            public virtual RepoItemInfo FermerInfo
            {
                get
                {
                    return _fermerInfo;
                }
            }
        }

        /// <summary>
        /// The SettingsOcmAppFolder folder.
        /// </summary>
        [RepositoryFolder("9e42c05d-ce95-47b1-9bff-a85f23860457")]
        public partial class SettingsOcmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _configurationInfo;
            RepoItemInfo _quitterInfo;

            /// <summary>
            /// Creates a new SettingsOcm  folder.
            /// </summary>
            public SettingsOcmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SettingsOcm", "/contextmenu[@processname='SettingsOcm']", parentFolder, 30000, null, false, "9e42c05d-ce95-47b1-9bff-a85f23860457", "")
            {
                _configurationInfo = new RepoItemInfo(this, "Configuration", "?/?/menuitem[@accessiblename='Configuration...']", "?/?/menuitem[@accessiblename='Configuration...']", 30000, null, "1790f3d9-81f3-45d6-9523-b9f186c1c33e");
                _quitterInfo = new RepoItemInfo(this, "Quitter", "?/?/menuitem[@accessiblename='Quitter']", "?/?/menuitem[@accessiblename='Quitter']", 30000, null, "fe5f7453-880a-45a7-83bd-db2aa4d85713");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9e42c05d-ce95-47b1-9bff-a85f23860457")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9e42c05d-ce95-47b1-9bff-a85f23860457")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Configuration item.
            /// </summary>
            [RepositoryItem("1790f3d9-81f3-45d6-9523-b9f186c1c33e")]
            public virtual Ranorex.MenuItem Configuration
            {
                get
                {
                    return _configurationInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Configuration item info.
            /// </summary>
            [RepositoryItemInfo("1790f3d9-81f3-45d6-9523-b9f186c1c33e")]
            public virtual RepoItemInfo ConfigurationInfo
            {
                get
                {
                    return _configurationInfo;
                }
            }

            /// <summary>
            /// The Quitter item.
            /// </summary>
            [RepositoryItem("fe5f7453-880a-45a7-83bd-db2aa4d85713")]
            public virtual Ranorex.MenuItem Quitter
            {
                get
                {
                    return _quitterInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Quitter item info.
            /// </summary>
            [RepositoryItemInfo("fe5f7453-880a-45a7-83bd-db2aa4d85713")]
            public virtual RepoItemInfo QuitterInfo
            {
                get
                {
                    return _quitterInfo;
                }
            }
        }

        /// <summary>
        /// The ConfirmAppFolder folder.
        /// </summary>
        [RepositoryFolder("3c0c6e0d-7a18-4679-a9e2-f84e0de22953")]
        public partial class ConfirmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonyesInfo;

            /// <summary>
            /// Creates a new Confirm  folder.
            /// </summary>
            public ConfirmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Confirm", "/form[@name='none']", parentFolder, 30000, null, true, "3c0c6e0d-7a18-4679-a9e2-f84e0de22953", "")
            {
                _buttonyesInfo = new RepoItemInfo(this, "ButtonYes", "button[@name='Yes']", "button[@name='Yes']", 30000, null, "3e9e882d-9579-4abe-ac53-4ffa281e62d1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3c0c6e0d-7a18-4679-a9e2-f84e0de22953")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3c0c6e0d-7a18-4679-a9e2-f84e0de22953")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonYes item.
            /// </summary>
            [RepositoryItem("3e9e882d-9579-4abe-ac53-4ffa281e62d1")]
            public virtual Ranorex.Button ButtonYes
            {
                get
                {
                    return _buttonyesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonYes item info.
            /// </summary>
            [RepositoryItemInfo("3e9e882d-9579-4abe-ac53-4ffa281e62d1")]
            public virtual RepoItemInfo ButtonYesInfo
            {
                get
                {
                    return _buttonyesInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
