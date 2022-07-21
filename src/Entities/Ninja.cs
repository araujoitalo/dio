namespace dio.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

        public override string Attack(){
            return this.Name + " Atacou com seus golpes";
        }

        public string Attack(int Bonus){

        if (Bonus > 7){
             return this.Name + " Atacou com seus Golpes super efetivos com bonus de ataque de " + Bonus;
        }else
        {
            return this.Name + " Atacou com seus golpes com força fraca com bonus de " + Bonus;
        }
            
    }
}
}