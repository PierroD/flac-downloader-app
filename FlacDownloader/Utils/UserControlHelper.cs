using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Utils
{
    public static class UserControlHelper
    {
        public static void Switch(Panel panel, UserControl userControl)
        {
            if (!panel.Controls.Contains(userControl))
            {
                panel.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
                userControl.BringToFront();
        }

        public static void CallEventOnAllPanels(Panel panel, string functionName, params object[] parameters)
        {
            foreach(Control control in panel.Controls)
            {
                Type controlType = control.GetType();
                
                if(controlType.BaseType.Name != "UserControl")
                {
                    continue;
                }

                MethodInfo methodInfo = controlType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Instance);

                if (methodInfo != null)
                {
                    try
                    {
                        // Check if the method parameters match the provided parameters
                        ParameterInfo[] methodParams = methodInfo.GetParameters();
                        int parameterLength = parameters == null ? 0 : parameters.Length;
                        if (methodParams.Length == parameterLength)
                        {
                            object[] adjustedParameters = null;
                            if (parameterLength != 0)
                            {
                                 adjustedParameters = new object[parameters.Length];
                                for (int i = 0; i < parameters.Length; i++)
                                {
                                    adjustedParameters[i] = parameters[i] ?? Type.Missing;
                                }
                            }

                            // Invoke the method on the control with the parameters
                            methodInfo.Invoke(control, adjustedParameters);
                        }
                        else
                        {
                            MessageBox.Show($"Parameter count mismatch for method '{functionName}' on control '{control.Name}'");
                        }
                    }
                    catch (TargetInvocationException ex)
                    {
                        // Handle the exception thrown by the invoked method
                        MessageBox.Show($"Error invoking method '{functionName}' on control '{control.Name}': {ex.InnerException.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle any other reflection-related exceptions
                        MessageBox.Show($"Error invoking method '{functionName}' on control '{control.Name}': {ex.Message}");
                    }
                }
            }
        }
    }
}
