using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectionMethods;
using Algorithms;

namespace GeneticAlgorithm
{
    static class Parameters
    {
        #region DDL population
        public static Dictionary<string, string> getDDLEvaluators()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if ((t.GetInterface("IEvaluator") != null) &&
                    ((t.GetCustomAttribute(typeof(StatusAttribute)) as StatusAttribute).current == Utilities.DevelopementStatus.Active))
                {
                    var attribute = t.GetCustomAttribute(typeof(DDLAttribute)) as DDLAttribute;
                    dict.Add(attribute.key, attribute.value);
                }
            }
            return dict;
        }
        public static Dictionary<string, string> getDDLAlgorithmStopConditions()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.Namespace == "Algorithms" && t.IsClass && !t.IsAbstract &&
                    ((t.GetCustomAttribute(typeof(StatusAttribute)) as StatusAttribute).current == Utilities.DevelopementStatus.Active))
                {
                    var attribute = t.GetCustomAttribute(typeof(DDLAttribute)) as DDLAttribute;
                    dict.Add(attribute.key, attribute.value);
                }
            }
            return dict;
        }

        public static Dictionary<string, string> getDDLSelectionMethods()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.Namespace == "SelectionMethods" && t.IsClass && !t.IsAbstract &&
                    ((t.GetCustomAttribute(typeof(StatusAttribute)) as StatusAttribute).current == Utilities.DevelopementStatus.Active))
                {
                    var attribute = t.GetCustomAttribute(typeof(DDLAttribute)) as DDLAttribute;
                    dict.Add(attribute.key, attribute.value);
                }
            }
            return dict;
        }
        public static Dictionary<string, string> getDDLPixelGenerators()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if ((t.GetInterface("IPixelGenerator") != null) && !t.IsAbstract &&
                    ((t.GetCustomAttribute(typeof(StatusAttribute)) as StatusAttribute).current == Utilities.DevelopementStatus.Active))
                {
                    var attribute = t.GetCustomAttribute(typeof(DDLAttribute)) as DDLAttribute;
                    dict.Add(attribute.key, attribute.value);
                }
            }
            return dict;
        }
        #endregion

        #region Get image settings    
        public static int getImageSize()
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxImageSettings"].Controls["txtImageSize"].Text, System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static bool getCheckBoxGraphic()
        {
            return ((CheckBox)(Application.OpenForms["Home"].Controls["boxImageSettings"].Controls["checkBoxGraphic"])).Checked;
        }
        public static bool getCheckBoxRealTimeGraphic()
        {
            return ((CheckBox)(Application.OpenForms["Home"].Controls["boxImageSettings"].Controls["checkBoxRealTimeGraphic"])).Checked;
        }
        public static bool getCheckBoxRealTimeImage()
        {
            return ((CheckBox)(Application.OpenForms["Home"].Controls["boxImageSettings"].Controls["checkBoxRealTimeImage"])).Checked;
        }
        #endregion

        #region Get algorithm settings

        public static string getEvaluator()
        {
            ComboBox sel = (ComboBox)Application.OpenForms["Home"].Controls["boxExperimentSettings"].Controls["ddlEvaluator"];
            if (sel.InvokeRequired)
            {
                string res = "";
                sel.Invoke((MethodInvoker)(delegate { res = sel.SelectedValue.ToString(); }));
                return res;
            }
            return sel.SelectedValue.ToString();
        }
        public static double getMergePercent()
        {
            return Convert.ToDouble(Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["txtMergePercent"].Text, System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        public static double getMutationPercent()
        {
            return Convert.ToDouble(Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["txtMutationPercent"].Text, System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        public static int getPopulationSize()
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["txtPopulationSize"].Text, System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        public static int getGenerations()
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["txtStopValue"].Text, System.Globalization.NumberFormatInfo.InvariantInfo);
        }
        public static string getSelectionMethod()
        {
            ComboBox sel = (ComboBox)Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["ddlSelection"];
            if (sel.InvokeRequired)
            {
                string res = "";
                sel.Invoke((MethodInvoker)(() => res = sel.SelectedValue.ToString()));
                return res;
            }
            return sel.SelectedValue.ToString();
        }
        public static string getStopCondition()
        {
            ComboBox sel = (ComboBox)Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["ddlStopCondition"];
            if (sel.InvokeRequired)
            {
                string res = "";
                sel.Invoke((MethodInvoker)(delegate { res = sel.SelectedValue.ToString(); }));
                return res;
            }
            return sel.SelectedValue.ToString();
        }
        public static float getStopValue()
        {
            TextBox txt = (TextBox)Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["txtStopValue"];
            if (txt.InvokeRequired)
            {
                float res = 0;
                txt.Invoke((MethodInvoker)(delegate { res = float.Parse(txt.Text, System.Globalization.NumberFormatInfo.InvariantInfo); }));
                return res;
            }
            return float.Parse(txt.Text);
        }
        public static string getCalculationMethod()
        {
            ComboBox sel = (ComboBox)Application.OpenForms["Home"].Controls["boxAlgorithmSettings"].Controls["ddlCalculationMethod"];
            if (sel.InvokeRequired)
            {
                string res = "";
                sel.Invoke((MethodInvoker)(delegate { res = sel.SelectedValue.ToString(); }));
                return res;
            }
            string r = sel.SelectedValue.ToString();
            return sel.SelectedValue.ToString();
        }
        public static int getModulatorMonitorNumber()
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxExperimentSettings"].Controls["txtModulatorMonitorNumber"].Text);
        }
        #endregion

        #region Get parameters settings
        public static List<Gene> getParametersAsGenes()
        {
            List<Gene> res = new List<Gene>();
            int i = 1;
            while (true)
            {
                if ((CheckBox)(Application.OpenForms["Home"].Controls["boxParametersSettings"].Controls["panelParameters"].Controls["checkBoxA" + i.ToString()]) == null || !getParameterChecked(i))
                {
                    break;
                }
                res.Add(new Gene(getParameterMinValue(i), getParameterMaxValue(i)));
                i++;
            }
            return res;
        }
        public static bool getParameterChecked(int parameterNumber)
        {
            return ((CheckBox)(Application.OpenForms["Home"].Controls["boxParametersSettings"].Controls["panelParameters"].Controls["checkBoxA" + parameterNumber.ToString()])).Checked;
        }

        public static int getParameterMinValue(int parameterNumber)
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxParametersSettings"].Controls["panelParameters"].Controls["txtA" + parameterNumber.ToString() + "Min"].Text);
        }

        public static int getParameterMaxValue(int parameterNumber)
        {
            return Convert.ToInt32(Application.OpenForms["Home"].Controls["boxParametersSettings"].Controls["panelParameters"].Controls["txtA" + parameterNumber.ToString() + "Max"].Text);
        }
        #endregion
    }
}
