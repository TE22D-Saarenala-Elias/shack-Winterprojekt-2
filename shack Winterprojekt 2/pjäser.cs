using Raylib_cs;
// public class vp{
class Vkung
{
    int x;
    int y;
    public void display(int tempX, int tempY)
    {
        x = tempX;
        y = tempY;
        Texture2D imgVku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_kung.png");
        Raylib.DrawTexture(imgVku, (int)x, (int)y, Color.White);
    }
    // bool dead;
    // if (dead){
    //     gameover
    //     svart parti vann
    // }

}

class Vdrottning
{
int x;
int y;
    public void display()
    {
        Texture2D imgVd = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_drottning.png");
        Raylib.DrawTexture(imgVd, x, y, Color.White);
    }
}
class Vknäkt
{
    public int x0=225;
    public int y0=720;


    public void Display()
    {    //x0 är x-kordinaten för knäkt 1 och y0 är y-kordinaten för knäkt 1
        // int x0 = 225;
        // int y0 = 720;

        Texture2D imgVkn = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_knäkt.png");
        Raylib.DrawTexture(imgVkn, x0, y0, Color.White);
    }
    public int x1 = 525; 
    public int y1 = 720;
    public void display1()
    {      //x1 är x-kordinaten för knäkt 2 och y1 är y-kordinaten för knäkt 2
        Texture2D imgVkn = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_knäkt.png");
        Raylib.DrawTexture(imgVkn, x1, y1, Color.White);
    }
}

 class Vhäst
{
     public int x0 = 150;
     public int y0 = 725;  

   
   public void display1()
    {
        Texture2D imgVh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_häst.png");
        Raylib.DrawTexture(imgVh, x0, y0, Color.White);
        
    }
     public int x1 = 650;
    public int y1 = 750;
    void display2()
    {
        Texture2D imgVh = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/vit_häst.png");
        Raylib.DrawTexture(imgVh, x1, y1, Color.White);
        
    }

}

class Vtorn
{
    float x;
    float y;
    void display(float tempX, float tempY)
    {
        x = tempX;
        y = tempY;

        // imageMode(CENTER);
        // image(imgvt,x,y);
    }
}

class Vbonde
{
    float x0 = 50; float y0 = 650;
    float x1 = 150; float y1 = 650;
    float x2 = 250; float y2 = 650;
    float x3 = 350; float y3 = 650;
    float x4 = 450; float y4 = 650;
    float x5 = 550; float y5 = 650;
    float x6 = 650; float y6 = 650;
    float x7 = 750; float y7 = 650;

    void display0()
    {

        // imageMode(CENTER);
        // image(imgvb,x0,y0);
    }

    void display1()
    {

        // imageMode(CENTER);
        // image(imgvb,x1,y1);
    }

    void display2()
    {

        // imageMode(CENTER);
        // image(imgvb,x2,y2);
    }

    void display3()
    {

        // imageMode(CENTER);
        // image(imgvb,x3,y3);
    }

    void display4()
    {

        // imageMode(CENTER);
        // image(imgvb,x4,y4);
    }

    void display5()
    {

        // imageMode(CENTER);
        // image(imgvb,x5,y5);
    }

    void display6()
    {

        // imageMode(CENTER);
        // image(imgvb,x6,y6);
    }

    void display7()
    {

        // imageMode(CENTER);
        // image(imgvb,x7,y7);
    }
}
// }

// public class sp{
public class Skung
{
    int x;
    int y;
    public void display(int tempX, int tempY)
    {
        x = tempX;
        y = tempY;
        Texture2D imgsku = Raylib.LoadTexture("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2/shack Winterprojekt 2/svart_kung.png");
        Rectangle skuRec = new Rectangle(x, y, imgsku.Width, imgsku.Height);
        Raylib.DrawTexture(imgsku, (int)x, (int)y, Color.White);
    }
}

class Sdrottning
{
    float x;
    float y;
    void display(float tempX, float tempY)
    {
        x = tempX;
        y = tempY;
        // imageMode(CENTER);
        // image(imgsd,x,y);
    }
}

class Sknäkt
{
    float x;
    float y;
    void display(float tempX, float tempY)
    {
        x = tempX;
        y = tempY;
        // imageMode(CENTER);
        // image(imgskn,x,y);
    }
}

class Shäst
{
    float x;
    float y;

    void display(float tempX, float tempY)
    {
        x = tempX;
        y = tempY;
        // imageMode(CENTER);
        // image(imgsh,x,y);
    }
}

class Storn
{
    float x;
    float y;
    void display(float tempX, float tempY)
    {
        x = tempX;
        y = tempY;
        // imageMode(CENTER);
        // image(imgst,x,y);
    }
}

class Sbonde
{
    float x0 = 50; float y0 = 150;
    float x1 = 150; float y1 = 150;
    float x2 = 250; float y2 = 150;
    float x3 = 350; float y3 = 150;
    float x4 = 450; float y4 = 150;
    float x5 = 550; float y5 = 150;
    float x6 = 650; float y6 = 150;
    float x7 = 750; float y7 = 150;
    public void display0()
    {

        // imageMode(CENTER);
        // image(imgsb,x0,y0);
    }

    public void display1()
    {

        // imageMode(CENTER);
        // image(imgsb,x1,y1);
    }

    public void display2()
    {

        // imageMode(CENTER);
        // image(imgsb,x2,y2);
    }

    public void display3()
    {

        // imageMode(CENTER);
        // image(imgsb,x3,y3);
    }

    public void display4()
    {

        // imageMode(CENTER);
        // image(imgsb,x4,y4);
    }

    public void display5()
    {

        // imageMode(CENTER);
        // image(imgsb,x5,y5);
    }

    public void display6()
    {

        // imageMode(CENTER);
        // image(imgsb,x6,y6);
    }

    public void display7()
    {

        // imageMode(CENTER);
        // image(imgsb,x7,y7);
    }

}
// }