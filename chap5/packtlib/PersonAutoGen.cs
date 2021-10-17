namespace Packt.Shared
{
    public partial class Person{
        public string Origin {
            get{
                return $"{name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{name} says Hi";
        public int age => System.DateTime.Today.Year - birthday.Year;

        public string FavIceCream { get; set; }

        public string favPrimaryColour { get; set; }

        public string FavPrimaryColor { 
            get
            {
                return favPrimaryColour;
            }        
            set
            {
                switch(value.ToLower()){
                    case "red":
                    case "green":
                    case "blue":
                        favPrimaryColour = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. Choose from: red, green, blue");
                        
                }
            }
        }

        public Person this[int index]{
            get{
                return Children[index];
            }
            set {
                Children[index] = value;
            }
        }
    }
   
}