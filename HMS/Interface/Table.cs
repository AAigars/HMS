namespace HMS.Interface
{
    public class Action
    {
        public Image image;
        public Action<object>? function;

        public Action(Image image, Action<object>? function)
        {
            this.image = image;
            this.function = function;   
        }
    }

    public class Table
    {
        private Control control;

        private List<Control> headings;
        private List<Control> entries;
        private List<Action> actions;

        private int offset;
        private int width;
        private int height;

        /// <summary>
        /// Custom implementation of a table
        /// </summary>
        /// <param name="control">Main control of table</param>
        /// <param name="height">Height of the headings/entries</param>
        public Table(Control control, int height = 40)
        {
            this.control = control;
            this.height = height;

            headings = new();
            entries = new();
            actions = new();
        }

        /// <summary>
        /// Creates the controls for displaying headers in the table
        /// </summary>
        /// <param name="headings">String array of all the headings</param>
        public void CreateHeader(string[] headings)
        {
            // calculate size of each heading
            width = control.Width / headings.Length;

            // iterate each heading and draw
            for(int i = 0; i < headings.Length; i++)
            {
                var header = headings[i];

                // create label
                var label = new Label();
                label.Text = header;
                label.TextAlign = ContentAlignment.MiddleCenter;

                // size & position
                label.Size = new Size(width, height);
                label.Location = new Point(i * width, 0);

                // font
                label.Font = new Font("Segoe UI Semibold", 10);
                label.ForeColor = Color.FromArgb(110, 114, 117);

                // assign to control
                control.Controls.Add(label);

                // store control
                this.headings.Add(label);
            }

            // increment offset
            offset += height;
        }

        /// <summary>
        /// Creates an action for the table entries
        /// </summary>
        /// <param name="image">Image to be used for the action</param>
        public void CreateAction(Image image, Action<object> function)
        {
            actions.Add(new Action(image, function));
        }

        /// <summary>
        /// Creates an entry into the table
        /// </summary>
        /// <param name="entries"></param>
        public void CreateEntry(string?[] entries, object? data = null)
        {
            // check for size calculation
            if (width == 0)
                return;

            // iterate each entry and draw
            for (int i  = 0; i < entries.Length; i++)
            {
                var entry = entries[i];

                // create label
                var label = new Label();
                label.Text = entry;
                label.TextAlign = ContentAlignment.MiddleCenter;

                // size & position
                label.Size = new Size(width, height);
                label.Location = new Point(i * width, offset);

                // font
                label.Font = new Font("Segoe UI Regular", 10);
                label.ForeColor = Color.FromArgb(110, 114, 117);

                // assign to control
                control.Controls.Add(label);

                // store control
                this.entries.Add(label);
            }

            // add actions to entry
            int actionOffset = (entries.Length * width) + (width / 2) - (actions.Count * 16);

            for (int i = 0; i < actions.Count; i++)
            {
                var action = actions[i];

                // create picturebox
                var pictureBox = new PictureBox();
                pictureBox.Image = action.image;
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

                // calculate size and location
                pictureBox.Size = new Size(32, height);
                pictureBox.Location = new Point(actionOffset, offset);

                // onclick
                if (action.function != null)
                {
                    pictureBox.Click += new EventHandler(delegate (object sender, EventArgs e)
                    {
                        action.function(data);
                    });
                }

                // assign to control
                control.Controls.Add(pictureBox);

                // store control
                this.entries.Add(pictureBox);

                // increment offset
                actionOffset += 32;
            }

            // increment offset
            offset += height;
        }

        /// <summary>
        /// Resets all of the internal offsets and clears any entries
        /// </summary>
        public void Clear()
        {
            // reset offset
            offset = height;

            // clear entries
            for (int i = 0; i < entries.Count; i++)
            {
                var entry = entries[i];

                // remove from control
                entry.Dispose();
            }
        }
    }
}
