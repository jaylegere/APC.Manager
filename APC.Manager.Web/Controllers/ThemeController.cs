using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APC.Manager.Web.Controllers {
	public class ThemeController : Controller {

		//
		// Example Pages
		//

		public ActionResult PageProfile() {
			ViewBag.Title = "Profile";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PageInvoice() {
			ViewBag.Title = "Invoice";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PagePricing() {
			ViewBag.Title = "Pricing Plans";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PageSupport() {
			ViewBag.Title = "Support Page";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PageGallery() {
			ViewBag.Title = "Gallery";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PageSettings() {
			ViewBag.Title = "Settings";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}

		public ActionResult PageCalendar() {
			ViewBag.Title = "Calendar";
			ViewBag.ActiveTab = "Example Pages";

			return View();
		}


		//
		// Form Elements
		//

		public ActionResult FormRegular() {
			ViewBag.Title = "Regular Elements";
			ViewBag.ActiveTab = "Form Elements";

			return View();
		}

		public ActionResult FormExtended() {
			ViewBag.Title = "Extended Elements";
			ViewBag.ActiveTab = "Form Elements";

			return View();
		}

		public ActionResult FormValidation() {
			ViewBag.Title = "Validation";
			ViewBag.ActiveTab = "Form Elements";

			return View();
		}


		//
		// UI Features
		//

		public ActionResult UIButtons() {
			ViewBag.Title = "Buttons";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}

		public ActionResult UITabs() {
			ViewBag.Title = "Tabs";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}

		public ActionResult UIPopups() {
			ViewBag.Title = "Popups";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}

		public ActionResult UISliders() {
			ViewBag.Title = "Sliders";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}

		public ActionResult UITypography() {
			ViewBag.Title = "Typography";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}

		public ActionResult UIIcons() {
			ViewBag.Title = "Icons";
			ViewBag.ActiveTab = "UI Features";

			return View();
		}


		//
		// Tables
		//

		public ActionResult TableBasic() {
			ViewBag.Title = "Basic Tables";
			ViewBag.ActiveTab = "Tables";

			return View();
		}

		public ActionResult TableAdvanced() {
			ViewBag.Title = "Advanced Tables";
			ViewBag.ActiveTab = "Tables";

			return View();
		}

		public ActionResult TableResponsive() {
			ViewBag.Title = "Responsive Tables";
			ViewBag.ActiveTab = "Tables";

			return View();
		}


		//
		// Portlets
		//

		public ActionResult UIPortlets() {
			ViewBag.Title = "Portlets";
			ViewBag.ActiveTab = "Portlets";

			return View();
		}

		//
		// Charts & Graphs
		//

		public ActionResult ChartFlot() {
			ViewBag.Title = "jQuery Flot";
			ViewBag.ActiveTab = "Charts & Graphs";

			return View();
		}

		public ActionResult ChartMorris() {
			ViewBag.Title = "Morris.js";
			ViewBag.ActiveTab = "Charts & Graphs";

			return View();
		}


		//
		// Extra Pages
		//

		public ActionResult PageLoginBasic() {
			ViewBag.Title = "Login - Basic";
			ViewBag.ActiveTab = "Extra Pages";

			return View();
		}

		public ActionResult PageLoginSocial() {
			ViewBag.Title = "Login - Social";
			ViewBag.ActiveTab = "Extra Pages";

			return View();
		}

		public ActionResult Page404() {
			ViewBag.Title = "Page Not Found";
			ViewBag.ActiveTab = "Extra Pages";

			return View();
		}

		public ActionResult Page500() {
			ViewBag.Title = "Internal Server Error";
			ViewBag.ActiveTab = "Extra Pages";

			return View();
		}

		public ActionResult PageBlank() {
			ViewBag.Title = "Blank Page";
			ViewBag.ActiveTab = "Extra Pages";

			return View();
		}
	}
}