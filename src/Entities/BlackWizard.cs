namespace dio.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

         public override string Attack(){
            return this.Name + " Lançou Magia Negra";
        }

        public string Attack(int Bonus){

        if (Bonus > 15){
             return this.Name + " Lançou Magia Negra super efetiva com bonus de ataque de " + Bonus;
        }else
        {
            return this.Name + " Lançou uma Magia Negra com força fraca com bonus de " + Bonus;
        }
            
        }
    }
}
  