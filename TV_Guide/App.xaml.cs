using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TV_Guide
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        /// 
        private List<TV_Show> showList;
        private List<CastMember> bb_castList;
        private List<CastMember> got_castList;
        private List<CastMember> saul_castList;
        private List<CastMember> westworld_castList;
        private List<CastMember> sopranos_castList;
        private List<CastMember> arrestedDev_castList;
        private List<CastMember> strangerthings_castList;
        private List<CastMember> chernobyl_castList;
        private List<CastMember> bojack_castList;
        private List<CastMember> fleabag_castList;
        private List<CastMember> witcher_castList;
        private List<CastMember> theBoys_castList;
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            PopulateShowList();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        public void PopulateShowList()
        {
            showList = new List<TV_Show>();

            bb_castList = new List<CastMember>();
            CastRole WalterWhite = new CastRole("Actor", new DateTime(1980, 1, 1));
            CastRole JessePinkman = new CastRole("Actor", new DateTime(1998, 1, 1));
            CastRole Creator_BB = new CastRole("Director", new DateTime(1990, 1, 1));
            CastMember BC_BB = new CastMember { FirstName = "Bryan", LastName = "Cranston", Role = WalterWhite, DOB = new DateTime(1956, 3, 7) };
            CastMember AP_BB = new CastMember { FirstName = "Aaron", LastName = "Paul", Role = JessePinkman, DOB = new DateTime(1979, 8, 27) };
            CastMember VG_BB = new CastMember { FirstName = "Vince", LastName = "Gilligan", Role = Creator_BB, DOB = new DateTime(1967, 2, 10) };
            bb_castList.Add(BC_BB);
            bb_castList.Add(AP_BB);
            bb_castList.Add(VG_BB);

            got_castList = new List<CastMember>();
            CastRole Khaleesi = new CastRole("Actor", new DateTime(2009, 1, 1));
            CastRole JonSnow = new CastRole("Actor", new DateTime(2008, 1, 1));
            CastRole Tyrion = new CastRole("Actor", new DateTime(1995, 1, 1));
            CastMember EC_GOT = new CastMember { FirstName = "Emilia", LastName = "Clarke", Role = Khaleesi, DOB = new DateTime(1986, 10, 23) };
            CastMember KH_GOT = new CastMember { FirstName = "Kit", LastName = "Harrington", Role = JonSnow, DOB = new DateTime(1986, 12, 26) };
            CastMember PD_GOT = new CastMember { FirstName = "Peter", LastName = "Dinklage", Role = Tyrion, DOB = new DateTime(1969, 6, 11) };
            got_castList.Add(EC_GOT);
            got_castList.Add(KH_GOT);
            got_castList.Add(PD_GOT);

            saul_castList = new List<CastMember>();
            CastRole Saul = new CastRole("Actor", new DateTime(1987, 1, 1));
            CastRole Gus = new CastRole("Actor", new DateTime(1966, 1, 1));
            CastRole Mike = new CastRole("Actor", new DateTime(1974, 1, 1));
            CastMember BO_Saul = new CastMember { FirstName = "Bob", LastName = "Odenkirk", Role = Saul, DOB = new DateTime(1962, 10, 22) };
            CastMember GE_Saul = new CastMember { FirstName = "Giancarlo", LastName = "Esposito", Role = Gus, DOB = new DateTime(1958, 4, 26) };
            CastMember JB_Saul = new CastMember { FirstName = "Johnthan", LastName = "Banks", Role = Mike, DOB = new DateTime(1947, 1, 31) };
            saul_castList.Add(BO_Saul);
            saul_castList.Add(GE_Saul);
            saul_castList.Add(JB_Saul);

            westworld_castList = new List<CastMember>();
            CastRole Dolores = new CastRole("Actor", new DateTime(1994, 1, 1));
            CastRole Maeve = new CastRole("Actor", new DateTime(1991, 1, 1));
            CastRole Bernard = new CastRole("Actor", new DateTime(1990, 1, 1));
            CastMember ERW_WW = new CastMember { FirstName = "Evan", LastName = "Rachel-Wood", Role = Dolores, DOB = new DateTime(1987, 9, 7) };
            CastMember TN_WW = new CastMember { FirstName = "Thandie", LastName = "Newton", Role = Maeve, DOB = new DateTime(1972, 11, 6) };
            CastMember JW_WW = new CastMember { FirstName = "Jeffrey", LastName = "Wright", Role = Bernard, DOB = new DateTime(1965, 12, 7) };
            westworld_castList.Add(ERW_WW);
            westworld_castList.Add(TN_WW);
            westworld_castList.Add(JW_WW);

            sopranos_castList = new List<CastMember>();
            CastRole Tony = new CastRole("Actor", new DateTime(1980, 1, 1));
            CastRole Creator_Sop = new CastRole("Creator", new DateTime(1974, 1, 1));
            CastRole Paulie = new CastRole("Actor", new DateTime(1974, 1, 1));
            CastMember JG_Sop = new CastMember { FirstName = "James", LastName = "Gandolfini", Role = Tony, DOB = new DateTime(1961, 9, 18) };
            CastMember DC_Sop = new CastMember { FirstName = "David", LastName = "Chase", Role = Creator_Sop, DOB = new DateTime(1945, 8, 22) };
            CastMember TS_Sop = new CastMember { FirstName = "Tony", LastName = "Sirico", Role = Paulie, DOB = new DateTime(1942, 7, 29) };
            sopranos_castList.Add(JG_Sop);
            sopranos_castList.Add(DC_Sop);
            sopranos_castList.Add(TS_Sop);

            arrestedDev_castList = new List<CastMember>();
            CastRole Michael = new CastRole("Actor", new DateTime(1981, 1, 1));
            CastRole GOB = new CastRole("Actor", new DateTime(1996, 1, 1));
            CastRole Tobias = new CastRole("Actor", new DateTime(1981, 1, 1));
            CastMember JB_AD = new CastMember { FirstName = "Jason", LastName = "Bateman", Role = Michael, DOB = new DateTime(1969, 1, 14) };
            CastMember WA_AD = new CastMember { FirstName = "Will", LastName = "Arnett", Role = GOB, DOB = new DateTime(1970, 5, 4) };
            CastMember DC_AD = new CastMember { FirstName = "David", LastName = "Cross", Role = Tobias, DOB = new DateTime(1964, 4, 4) };
            arrestedDev_castList.Add(JB_AD);
            arrestedDev_castList.Add(WA_AD);
            arrestedDev_castList.Add(DC_AD);

            strangerthings_castList = new List<CastMember>();
            CastRole Joyce = new CastRole("Actor", new DateTime(1985, 1, 1));
            CastRole Mike_ST = new CastRole("Actor", new DateTime(2013, 1, 1));
            CastRole Eleven = new CastRole("Actor", new DateTime(2013, 1, 1));
            CastMember WR_ST = new CastMember { FirstName = "Winona", LastName = "Ryder", Role = Joyce, DOB = new DateTime(1971, 10, 29) };
            CastMember FW_ST = new CastMember { FirstName = "Finn", LastName = "Wolfhard", Role = Mike_ST, DOB = new DateTime(2002, 12, 23) };
            CastMember MBB_ST = new CastMember { FirstName = "Millie", LastName = "Brown", Role = Eleven, DOB = new DateTime(2004, 2, 19) };
            strangerthings_castList.Add(WR_ST);
            strangerthings_castList.Add(FW_ST);
            strangerthings_castList.Add(MBB_ST);

            chernobyl_castList = new List<CastMember>();
            CastRole Legasov = new CastRole("Actor", new DateTime(1989, 1, 1));
            CastRole Boris = new CastRole("Actor", new DateTime(1968, 1, 1));
            CastRole Dyatlov = new CastRole("Actor", new DateTime(1994, 1, 1));
            CastMember JH_Cher = new CastMember { FirstName = "Jared", LastName = "Harris", Role = Legasov, DOB = new DateTime(1961, 8, 24) };
            CastMember SS_Cher = new CastMember { FirstName = "Stellan", LastName = "Skarsgård", Role = Boris, DOB = new DateTime(1951, 6, 13) };
            CastMember PR_Cher = new CastMember { FirstName = "Paul", LastName = "Ritter", Role = Dyatlov, DOB = new DateTime(1966, 3, 5) };
            chernobyl_castList.Add(JH_Cher);
            chernobyl_castList.Add(SS_Cher);
            chernobyl_castList.Add(PR_Cher);

            bojack_castList = new List<CastMember>();
            CastRole Bojack = new CastRole("Actor", new DateTime(1996, 1, 1));
            CastRole Todd = new CastRole("Actor", new DateTime(1998, 1, 1));
            CastRole Diane = new CastRole("Actor", new DateTime(2004, 1, 1));
            CastMember WA_BH = new CastMember { FirstName = "Will", LastName = "Arnett", Role = Bojack, DOB = new DateTime(1970, 5, 4) };
            CastMember AP_BH = new CastMember { FirstName = "Aaron", LastName = "Paul", Role = Todd, DOB = new DateTime(1979, 8, 27) };
            CastMember AB_BH = new CastMember { FirstName = "Alison", LastName = "Brie", Role = Diane, DOB = new DateTime(1982, 12, 29) };
            bojack_castList.Add(WA_BH);
            bojack_castList.Add(AP_BH);
            bojack_castList.Add(AB_BH);

            fleabag_castList = new List<CastMember>();
            CastRole Creator_FB = new CastRole("Creator", new DateTime(2009, 1, 1));
            CastRole Godmother = new CastRole("Actor", new DateTime(2000, 1, 1));
            CastRole Claire = new CastRole("Actor", new DateTime(2006, 1, 1));
            CastMember PWB_FB = new CastMember { FirstName = "Phoebe", LastName = "Waller-Bridge", Role = Creator_FB, DOB = new DateTime(1985, 7, 14) };
            CastMember OC_FB = new CastMember { FirstName = "Olivia", LastName = "Colman", Role = Godmother, DOB = new DateTime(1974, 1, 30)};
            CastMember SC_FB = new CastMember { FirstName = "Sian", LastName = "Clifford", Role = Claire, DOB = new DateTime(1982, 4, 7) };
            fleabag_castList.Add(PWB_FB);
            fleabag_castList.Add(OC_FB);
            fleabag_castList.Add(SC_FB);

            witcher_castList = new List<CastMember>();
            CastRole Geralt = new CastRole("Actor", new DateTime(2001, 1, 1));
            CastRole Yennefer = new CastRole("Actor", new DateTime(2016, 1, 1));
            CastRole Ciri = new CastRole("Actor", new DateTime(2017, 1, 1));
            CastMember HC_W = new CastMember { FirstName = "Henry", LastName = "Cavill", Role = Geralt, DOB = new DateTime(1983, 5, 5)};
            CastMember AC_W = new CastMember { FirstName = "Anya", LastName = "Chalotra", Role = Yennefer, DOB = new DateTime(1996, 7, 21)};
            CastMember FA_W = new CastMember { FirstName = "Freya", LastName = "Allan", Role = Ciri, DOB = new DateTime(2001, 9, 6)};
            witcher_castList.Add(HC_W);
            witcher_castList.Add(AC_W);
            witcher_castList.Add(FA_W);

            theBoys_castList = new List<CastMember>();
            CastRole Butcher = new CastRole("Actor", new DateTime(1990, 1, 1));
            CastRole Hughie = new CastRole("Actor", new DateTime(2012, 1, 1));
            CastRole Homelander = new CastRole("Actor", new DateTime(1995, 1, 1));
            CastMember KU_tB = new CastMember { FirstName = "Karl", LastName = "Urban", Role = Butcher, DOB = new DateTime(1972, 6, 7)};
            CastMember JQ_tB = new CastMember { FirstName = "Jack", LastName = "Quaid", Role = Hughie, DOB = new DateTime(1992, 4, 24)};
            CastMember AS_tB = new CastMember { FirstName = "Anthony", LastName = "Starr", Role = Homelander, DOB = new DateTime(1975, 10, 25)};
            theBoys_castList.Add(KU_tB);
            theBoys_castList.Add(JQ_tB);
            theBoys_castList.Add(AS_tB);


            TV_Show bBad = new TV_Show { Title = "Breaking Bad", Year = "2008", Genre = "Crime Drama", Photo = "BB.jpg", Channel = "AMC", castList = bb_castList };
            TV_Show gOt = new TV_Show { Title = "Game of Thrones", Year = "2011", Genre = "Fantasy", Photo = "GOT.jpg", Channel = "HBO", castList = got_castList };
            TV_Show sAul = new TV_Show { Title = "Better Call Saul", Year = "2015", Genre = "Crime Drama", Photo = "Saul.jpg", Channel = "AMC", castList = saul_castList };
            TV_Show westWorld = new TV_Show { Title = "Westworld", Year = "2016", Genre = "Sci-Fi", Photo = "WW.jpg", Channel = "HBO", castList = westworld_castList};
            TV_Show arrestedDev = new TV_Show { Title = "Arrested Development", Year = "2003", Genre = "Comedy", Photo = "AD.jpg", Channel = "Netflix", castList = arrestedDev_castList};
            TV_Show theSopranos = new TV_Show { Title = "The Sopranos", Year = "1999", Genre = "Crime Drama", Photo="Sopranos.jpg", Channel= "HBO", castList = sopranos_castList};
            TV_Show strangerThings = new TV_Show { Title = "Stranger Things", Year = "2016", Genre = "Sci-Fi", Photo = "ST.jpg", Channel = "Netflix", castList = strangerthings_castList};
            TV_Show chernobyl = new TV_Show { Title = "Chernobyl", Year = "2019", Genre = "Historical Drama", Photo = "Chernobyl.jpg", Channel = "HBO", castList = chernobyl_castList};
            TV_Show bojackHorseman = new TV_Show { Title = "Bojack Horseman", Year = "2014", Genre = "Comedy", Photo = "bojack.jpg", Channel = "Netflix", castList = bojack_castList};
            TV_Show fleabag = new TV_Show { Title = "Fleabag", Year = "2016", Genre = "Comedy", Photo = "fleabag.jpg", Channel = "Amazon", castList = fleabag_castList};
            TV_Show witcher = new TV_Show { Title = "The Witcher", Year = "2019", Genre = "Fantasy", Photo = "witcher.jpg", Channel = "Netflix", castList = witcher_castList};
            TV_Show theBoys = new TV_Show { Title = "The Boys", Year = "2019", Genre = "Action", Photo = "the_boys.jpg", Channel = "Amazon", castList = theBoys_castList };

            showList.Add(bBad);
            showList.Add(gOt);
            showList.Add(sAul);
            showList.Add(westWorld);
            showList.Add(arrestedDev);
            showList.Add(theSopranos);
            showList.Add(strangerThings);
            showList.Add(chernobyl);
            showList.Add(bojackHorseman);
            showList.Add(fleabag);
            showList.Add(witcher);
            showList.Add(theBoys);
        }
    }
}
