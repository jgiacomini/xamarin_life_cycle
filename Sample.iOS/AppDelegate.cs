using System;
using Foundation;
using UIKit;

namespace Sample.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {

		public override void OnActivated(UIApplication application)
		{
        	Console.WriteLine("-> OnActivated appelée, l'application est active.");
		}

		public override void WillEnterForeground(UIApplication application)
		{
			Console.WriteLine("-> WillEnterForeground, L'application va passer en premier plan");
		}
		
        public override void OnResignActivation(UIApplication application)
		{
            Console.WriteLine("-> OnResignActivation appelée, L'application passe à l'état inactif.");
		}

		public override void DidEnterBackground(UIApplication application)
		{
			Console.WriteLine("-> DidEnterBackground appelée, l’application passe à l’état arrière-plan");
		}

		// not guaranteed that this will run
		public override void WillTerminate(UIApplication application)
		{
			Console.WriteLine("--> WillTerminate appelée, l'application va s’arrêter.");
		}

    }
}