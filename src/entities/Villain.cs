namespace Heroes.src.entities
{
    public class Villain : Hero
    {
        public Villain(string Name, string VillainClass, int Level, string Weapon) {
            this.Name = Name;
            this.VillainClass = VillainClass;
            this.Level = Level;
            this.Weapon = Weapon;
        }
        public string VillainClass;
        public Villain() {}
        public override string ToString() {
            return $"{this.Name} is a level {this.Level} {this.VillainClass}.";
        }
        public string Attack(Hero SelectedEnemy) {
            return $"{this.Name} attacks {SelectedEnemy.Name} with their {this.Weapon}.";
        }
        public string Attack(Hero SelectedEnemy, int Bonus) {
            return $"{this.Name} attacks {SelectedEnemy.Name} with their {this.Weapon} and causing {Bonus} bonus damage.";
        }
    }
}