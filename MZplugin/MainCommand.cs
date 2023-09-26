using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace MZplugin
{
    [Transaction(TransactionMode.Manual)]
    public class MainCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Приветствие", "Hi, my friend!");
            
            return Result.Succeeded;
        }
    }
}
