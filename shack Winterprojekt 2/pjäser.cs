using Raylib_cs;
// public class vp{
 class Vkung
{
   public int x;
   public int y;
    Texture2D imgVku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_kung.png");

    public void display()
    {
                Raylib.DrawTexture(imgVku, x, y, Color.White);
    }
    // bool dead;
    // if (dead){
    //     gameover
    //     svart parti vann
    // }

}

class Vdrottning
{
 public int x;
 public int y;
 Texture2D imgVd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_drottning.png");

    public void display()
    {
               Raylib.DrawTexture(imgVd, x, y, Color.White);
    }
}

class Vtorn
{
   public int x;
   public int y;
    Texture2D imgVt = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_torn.png");

    public void display()
    {
        Raylib.DrawTexture(imgVt, x, y, Color.White);

    }
   
}

class Vknäkt
{
    public int x;//225
    public int y;//720
 Texture2D imgVkn = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_knäkt.png");
    public void display()
    {    
               Raylib.DrawTexture(imgVkn, x, y, Color.White); //x är x-kordinaten för knäkten och y är y-kordinaten för knäkten 
    }                           //imgVkn=image Vit Knäkt

}

 public class Vhäst
{
     public int x;//125 //625
     public int y;  
 Texture2D imgVh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_häst.png");
      
   public void display() 
    {
        Raylib.DrawTexture(imgVh, x, y, Color.White); 
    }
}

class Vbonde
{
   public int x;
   public int y;
  
Texture2D imgVb = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_bonde.png");
 
   public void display() 
   {
    Raylib.DrawTexture(imgVb, x, y, Color.White); 
   }
}
// }
//-----------------------------------------------------------------------------------------------------------------------------------------------------
// public class sp{
public class Skung
{
    public int x=325;
    public int y=20;
    Texture2D imgsku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_kung.png");
       
    public void display()
    {
        Raylib.DrawTexture(imgsku, x, y, Color.White);
    }
}

class Sdrottning
{
    public int x;
    public int y;
    Texture2D imgsd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_drottning.png");
    public void display()
    {
        Raylib.DrawTexture(imgsd, x, y, Color.White);
    }
}

class Sknäkt
{
    public int x;
    public int y;
    Texture2D imgsku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_knäkt.png");
    public void display()
    {
        Raylib.DrawTexture(imgsku, x, y, Color.White);
    }
}

class Shäst
{
    public int x;
    public int y;
    Texture2D imgsh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_häst.png");
    public void display()
    {
        Raylib.DrawTexture(imgsh, x, y, Color.White);
    }
   
}

class Storn
{
    public int x;
    public int y;
    Texture2D imgst = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_torn.png");
    public void display()
    {
        Raylib.DrawTexture(imgst, x, y, Color.White);
    }
   
}

class Sbonde
{
    public int x; 
    public int y;
    Texture2D imgsb = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_bonde.png");
    public void display() 
    {
         Raylib.DrawTexture(imgsb, x, y, Color.White); 
    }


}
// }