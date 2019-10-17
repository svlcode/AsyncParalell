using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class HandlingExceptionsForm : BaseListBoxProgressForm
    {
        public HandlingExceptionsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// All exceptions must be "observed" in order not to be re-thrown when the a task is garbage-collected.
        /// Use one of the following patterns to observe an exception thrown in a task:
        /// 1. call .Wait or touch .Result - exception is re-thrown at this point, or
        /// 2. call Task.WaitAll - exception(s) re-thrown at this point, or
        /// 3. touch task's .Exception property *after* task has completed, or
        /// 4. subscribe to TaskScheduler.UnobservedTaskException
        /// </summary>
        protected override void OnStart()
        {
            List<Task> tasks = new List<Task>();

            tasks.Add(Task.Run(() => { throw new InvalidOperationException(); }));
            tasks.Add(Task.Run(() => { int s = 0; s = 4 / s; }));
            tasks.Add(Task.Run(() => { throw new ArgumentNullException(); }));
            tasks.Add(Task.Run(() => { throw new FormatException(); }));
            tasks.Add(Task.Run(() =>
            {
                Task.Run(() =>
                {
                    throw new NotImplementedException();
                }).Wait();
            }));
            tasks.Add(Task.Run(() => 
            {
                Task.Run(() =>  
                {
                    Task.Run(() => 
                    {
                        throw new ArgumentNullException("test");
                    }).Wait();
                }).Wait();
            }));

            // In contrast to 'Task.WaitAll', 'await Task.WhenAll' is non-blocking,
            // but it throws only the first Exception

            try
            {
                Task.WaitAll(tasks.ToArray());
            }
            catch (AggregateException ae)
            {
                var newAe = ae.Flatten();
                string errors = "";
                foreach (var exception in newAe.InnerExceptions)
                {
                    errors += exception.Message + Environment.NewLine;
                }
                MessageBox.Show(errors);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
