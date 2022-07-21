namespace dio.src.Entities
{
    public class WhiteWizard : Hero {
        
   
     public WhiteWizard(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

    public override string Attack(){
            return this.Name + " Lançou Magia Branca";
        }
        
    public string Attack(int Bonus){

        if (Bonus > 12){
             return this.Name + " Lançou Magia Branca super efetiva com bonus de ataque de " + Bonus;
        }else
        {
            return this.Name + " Lançou uma Magia Branca com força fraca com bonus de " + Bonus;
        }
            
        }
    }
}