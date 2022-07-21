namespace dio.src.Entities
{
    public class Knight : Hero
    {
        
     public Knight(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

     public string Attack(int Bonus){

        if (Bonus > 3){
             return this.Name + " Atacou com sua espada super efetiva com bonus de ataque de " + Bonus;
        }else
        {
            return this.Name + " Atacou com sua espada com força fraca com bonus de " + Bonus;
        }
            
        }
    }
    
}