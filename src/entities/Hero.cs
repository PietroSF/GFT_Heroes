namespace Heroes.src.entities
{
    public class Hero
    {
        public Hero(string Name, string HeroClass, int Level, string Weapon) {
            this.Name = Name;
            this.HeroClass = HeroClass;
            this.Level = Level;
            this.Weapon = Weapon;
        }
        public string Name { get; set; }
        public string HeroClass { get; set; }
        public int Level { get; set; }
        public string Weapon { get; set; }
        public Hero() {}
        public override string ToString() {
            return $"{this.Name} is a level {this.Level} {this.HeroClass}.";
        }
        public string Attack(Villain SelectedEnemy) {
            return $"{this.Name} attacks {SelectedEnemy.Name} with their {this.Weapon}.";
        }
        public string Attack(Villain SelectedEnemy, int Bonus) {
            return $"{this.Name} attacks {SelectedEnemy.Name} with their {this.Weapon} and causing {Bonus} bonus damage.";
        }
    }
}