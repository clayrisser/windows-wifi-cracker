namespace Windows_Wi_Fi_Cracker {
    class Profile {

        private string name = "";
        private string key = "";

        public Profile(string name, string key) {
            this.name = name;
            this.key = key;
        }

        public string Name {
            get { return this.name; }
        }

        public string Key {
            get { return this.key; }
        }

    }
}
