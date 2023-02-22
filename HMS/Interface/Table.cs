namespace HMS.Interface
{
    public class Action
    {
        public Image image;

        public Action(Image image)
        {
            this.image = image;
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

        public Table(Control control, int height = 40)
        {
            this.control = control;
            this.height = height;

            headings = new();
            entries = new();
            actions = new();
        }

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

        public void CreateAction(Image image)
        {
            actions.Add(new Action(image));
        }

        public void CreateEntry(string?[] entries)
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

                // assign to control
                control.Controls.Add(pictureBox);

                // increment offset
                actionOffset += 32;

            }

            // increment offset
            offset += height;
        }

        public void Clear()
        {
            // reset offset
            offset = height;

            // clear entries
            for (int i = 0; i < entries.Count; i++)
            {
                var entry = entries[i];

                // remove from control
                control.Controls.Remove(entry);

                // remove from list
                entries.RemoveAt(i);
            }
        }
    }
}
