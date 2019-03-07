using Autodesk.Revit.UI;
using System.IO;
using System.Reflection;

namespace rvtUnit
{
    public class EntryPoint : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel panel = application.CreateRibbonPanel("RvtUnit");
            PushButtonData data = new PushButtonData(
                "RunTests", "Run Tests",
                    Assembly.GetExecutingAssembly().Location,
                    "rvtUnit.Commands.rvtUnitCmd");
            PushButton button = panel.AddItem(data) as PushButton;

            return Result.Succeeded;
        }
    }
}
