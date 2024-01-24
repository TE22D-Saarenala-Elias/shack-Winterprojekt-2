using Raylib_cs;
// public class vp{
 class Vkung
{
   public int x=325;
   public int y=720;
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
 public int x=425;
public int y=720;
 Texture2D imgVd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_drottning.png");

    public void display()
    {
               Raylib.DrawTexture(imgVd, x, y, Color.White);
    }
}

class Vtorn
{
   public int x0=25;
   public int y0=720;
    Texture2D imgVt = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_torn.png");

    public void display0()
    {
        Raylib.DrawTexture(imgVt, x0, y0, Color.White);

    }
    int x1=725;
    int y1=720;
    
   public void display1()
    {
        Raylib.DrawTexture(imgVt, x1, y1, Color.White);

    }
}

class Vknäkt
{
    public int x0=225;
    public int y0=720;
 Texture2D imgVkn = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_knäkt.png");
    public void display0()
    {    
               Raylib.DrawTexture(imgVkn, x0, y0, Color.White); //x0 är x-kordinaten för knäkt 1 och y0 är y-kordinaten för knäkt 1
    }

    public int x1 = 525; 
    public int y1 = 720; 
    public void display1()
    {    
               Raylib.DrawTexture(imgVkn, x1, y1, Color.White); //x1 är x-kordinaten för knäkt 2 och y1 är y-kordinaten för knäkt 2
    }
}

 public class Vhäst
{
     public int x0 = 125;
     public int y0 = 720;  
 Texture2D imgVh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_häst.png");
      
   public void display0() //public void display0(int x, int y)
    {
        
        Raylib.DrawTexture(imgVh, x0, y0, Color.White);
        
    }
     public int x1 = 625;
    public int y1 = 720;
    public void display1()
    {
        Raylib.DrawTexture(imgVh, x1, y1, Color.White);
        
    }

}

class Vbonde
{
    int x0 = 25; int y0 = 620;
    int x1 = 125; int y1 = 620;
    int x2 = 225; int y2 = 620;
    int x3 = 325; int y3 = 620;
    int x4 = 425; int y4 = 620;
    int x5 = 525; int y5 = 620;
    int x6 = 625; int y6 = 620;
    int x7 = 725; int y7 = 620;
Texture2D imgVb = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_bonde.png");
 
   public void display0() {Raylib.DrawTexture(imgVb, x0, y0, Color.White); }

   public void display1() {Raylib.DrawTexture(imgVb, x1, y1, Color.White); }

   public void display2() {Raylib.DrawTexture(imgVb, x2, y2, Color.White); }

   public void display3() {Raylib.DrawTexture(imgVb, x3, y3, Color.White); }

   public void display4() {Raylib.DrawTexture(imgVb, x4, y4, Color.White); }

   public void display5() {Raylib.DrawTexture(imgVb, x5, y5, Color.White); }

   public void display6() {Raylib.DrawTexture(imgVb, x6, y6, Color.White); }

   public void display7() {Raylib.DrawTexture(imgVb, x7, y7, Color.White);    }
}
// }

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
    int x=425;
    int y=20;
    Texture2D imgsd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_drottning.png");
    public void display()
    {
        Raylib.DrawTexture(imgsd, x, y, Color.White);
    }
}

class Sknäkt
{
    int x0=225;
    int y0=20;
    Texture2D imgsku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_knäkt.png");
    public void display0()
    {
        Raylib.DrawTexture(imgsku, x0, y0, Color.White);
    }
    int x1=525;
    int y1=20;
    public void display1()
    {
        Raylib.DrawTexture(imgsku, x1, y1, Color.White);
    }
}

class Shäst
{
   int x0=125;
    int y0=20;
    Texture2D imgsh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_häst.png");
    public void display0()
    {
        Raylib.DrawTexture(imgsh, x0, y0, Color.White);
    }
    int x1=625;
    int y1=20;

    public void display1()
    {
        Raylib.DrawTexture(imgsh, x1, y1, Color.White);
    }
}

class Storn
{
    int x0=25;
    int y0=20;
    Texture2D imgst = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_torn.png");
    public void display0()
    {
        Raylib.DrawTexture(imgst, x0, y0, Color.White);
    }
    int x1=725;
    int y1=20;
    public void display1()
    {
        Raylib.DrawTexture(imgst, x1, y1, Color.White);
    }
}

class Sbonde
{
    int x0 = 25; int y0 = 120;
    int x1 = 125; int y1 = 120;
    int x2 = 225; int y2 = 120;
    int x3 = 325; int y3 = 120;
    int x4 = 425; int y4 = 120;
    int x5 = 525; int y5 = 120;
    int x6 = 625; int y6 = 120;
    int x7 = 725; int y7 = 120;
    Texture2D imgsb = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_bonde.png");
    public void display0() { Raylib.DrawTexture(imgsb, x0, y0, Color.White); }

    public void display1() { Raylib.DrawTexture(imgsb, x1, y1, Color.White); }

    public void display2() { Raylib.DrawTexture(imgsb, x2, y2, Color.White); }

    public void display3() { Raylib.DrawTexture(imgsb, x3, y3, Color.White); }

    public void display4() { Raylib.DrawTexture(imgsb, x4, y4, Color.White); }

    public void display5() { Raylib.DrawTexture(imgsb, x5, y5, Color.White); }

    public void display6() { Raylib.DrawTexture(imgsb, x6, y6, Color.White); }

    public void display7() { Raylib.DrawTexture(imgsb, x7, y7, Color.White); }

}
// }