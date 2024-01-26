using Raylib_cs;
using System.ComponentModel.Design;
using System.Numerics;


Raylib.InitWindow(1000, 800, "Hello");
Raylib.SetTargetFPS(60);




Vtorn[] Vts;
Vhäst[] Vhs;
Vknäkt[] Vkns;
Vbonde[] Vbs;

Storn[] Sts;
Shäst[] Shs;
Sknäkt[] Skns;
Sbonde[] Sbs;

 Vts = new Vtorn[2];
Vkns = new Vknäkt[2]; 
 Vhs = new Vhäst[2];  
 Vbs = new Vbonde[8];

 Sts = new Storn[2];
 Skns = new Sknäkt[2];
 Shs = new Shäst[2];
 Sbs = new Sbonde[8];

Skung Skung = new Skung(){x=325 , y=20 };                       // S står för svarta pjäser. t.ex Skung står för svart kung.
Sdrottning Sdrottning = new Sdrottning(){x=425 , y=20};
Sts[0] = new Storn() {x=25 , y=20};
Sts[1] = new Storn() {x=725 , y=20};

Shs[0] = new Shäst() {x=125 , y=20};
Shs[1] = new Shäst() {x=625 , y=20};

Skns[0] = new Sknäkt() {x=225 , y=20};
Skns[1] = new Sknäkt() {x=525 , y=20};

int BondeX=25;
for (int r = 0; r < 8; r++){
     Sbs[r] = new Sbonde(){x=BondeX , y=120}; 
     BondeX+=100;}

Vkung Vkung= new Vkung(){ x=325 , y=720 };          // V står för vita pjäser. t.ex Vkung står för vit kung.
Vdrottning Vdrottning = new Vdrottning(){x=425 , y=720}; 

Vkns[0] = new Vknäkt() {x=225 , y=720};             //Vkns = (V)Vit (kn)Knäkt (s)flera/array av
Vkns[1] = new Vknäkt() {x=520 , y=720};

Vhs[0] = new Vhäst() {x=125 , y=720};
Vhs[1] = new Vhäst() {x=625 , y=720};

Vts[0] = new Vtorn() {x= 25 , y=720};
Vts[1] = new Vtorn() {x=725 , y=720};




BondeX=25;
for (int r = 0; r < 8; r++){
     Vbs[r] = new Vbonde(){x=BondeX , y=620}; 
     BondeX+=100;}

//-----------------------------------------------------------------------------------------------------------

 while (!Raylib.WindowShouldClose())
{


//-------------------------------------------------------------------------------------------------------------------
//                              RENDERING
//---------------------------------------------------------------------------------------------------------------------


int rigtSide1 = 600;
int rigtSide2 = 700;
int i = 0;

Raylib.BeginDrawing();
for (int x = 0; x < 901; x =x+200){     //--------------------------------------
                     
  Raylib.DrawRectangle(x,i,100,100,Color.Black);                      // x = x-kordinaten för de svarta rutorna
  if (i >= 800) {                       // i = y-kordinaten för de svarta rutorna
    x = 901;
  }
  if (x == rigtSide1) {
     x = -100;                           //funktionen som skappar svarta rutor
     i += 100;
      }
  if (x == rigtSide2) {
     x = -200;
     i += 100;
      }                           //----------------------------------------------
}
                                    //--------------------------------------
     int l = 0;
      for (int z = 100; z < 901; z =z+200){     //funktionen som skappar gröna rutor
    Raylib.DrawRectangle(z,l,100,100,Color.Green);       //z = x-kordinaten för gröna fyrkanten
  if (l >= 800) {
    z = 901;                                   // l = y-kordinaten för gröna fyrkanten
  }
  if (z == rigtSide1+100) {
     z = -200;                           
     l += 100;
      }                                  
  if (z == rigtSide2+100) {
     z = -100;                          
     l += 100;
      }   
      }
      Raylib.DrawRectangle(800,0,1000,800,Color.White);     // Sidobrädet för tagna pjäser
                                   //--------------------------------------------
      
    
  
 
 
 Skung.display();
 Sdrottning.display();
  
 Skns[0].display();
 Skns[1].display();

  Shs[0].display();
  Shs[1].display(); 
  
  Sts[0].display();
  Sts[1].display();
 
  
  Sbs[0].display();
  Sbs[1].display();
  Sbs[2].display();
  Sbs[3].display();
  Sbs[4].display();
  Sbs[5].display();
  Sbs[6].display();
  Sbs[7].display();
  
  
  
  Vkung.display();
  Vdrottning.display();
  
   Vkns[0].display();
   Vkns[1].display();
  
   Vhs[0].display();
   Vhs[1].display();
  
  Vts[0].display();
  Vts[1].display();
  
  Vbs[0].display();
  Vbs[1].display();
  Vbs[2].display();
  Vbs[3].display();
  Vbs[4].display();
  Vbs[5].display();
  Vbs[6].display();
  Vbs[7].display();
bool placerad=true;
if ((Raylib.GetMouseX() < Vkung.x + 38 && Raylib.GetMouseX() > Vkung.x ) && (Raylib.GetMouseY() < Vkung.y + 78 && Raylib.GetMouseY() > Vkung.y )&&placerad){
        
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vkung.x = Raylib.GetMouseX() -19;
       Vkung.y = Raylib.GetMouseY() - 30;
       Vkung.display();
       placerad=false;
    }
    
if ((Skung.x < Vkung.x + 25 && Skung.x+25 > Vkung.x ) && (Skung.y+30 < Vkung.y + 75 && Skung.y > Vkung.y - 25 )&& placerad)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
    {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }

      }


   if ((Raylib.GetMouseX() < Vhs[0].x + 50 && Raylib.GetMouseX() > Vhs[0].x-25 ) && (Raylib.GetMouseY() < Vhs[0].y + 75 && Raylib.GetMouseY() > Vhs[0].y )&&(placerad)){
        
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vhs[0].x = Raylib.GetMouseX() -19;
       Vhs[0].y = Raylib.GetMouseY() - 30;
       Vhs[0].display();
       placerad=false;
    }           
    
if ((Skung.x < Vhs[0].x+50 && Skung.x > Vhs[0].x-25) &&
    (Skung.y < Vhs[0].y+75 && Skung.y > Vhs[0].y-25)&& placerad)// kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt 
    {                                                             // att pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }

      }

  
//   //Ifall Vhs[0](vit häst 1) anfaller en Sbs(svart bonde) så ska svarta bonden hamna brevid schackbrädet
   
//      if((Sbs[0].x0 == Vhs[0].x0) && (Sbs[0].y0 == Vhs[0].y0) ){
//        Sbs[0].x0 = 850; Sbs[0].y0 = 50;
//     }
//     if((Sbs[1].x1 == Vhs[0].x0) && (Sbs[1].y1 == Vhs[0].y0) ){
//       Sbs[1].x1 = 950; Sbs[1].y1 = 50;
//     }
//     if((Sbs[2].x2 == Vhs[0].x0) && (Sbs[2].y2 == Vhs[0].y0) ){
//       Sbs[2].x2 = 850; Sbs[2].y2 = 150;
//     }
//     if((Sbs[3].x3 == Vhs[0].x0) && (Sbs[3].y3 == Vhs[0].y0) ){
//       Sbs[3].x3 = 950; Sbs[3].y3 = 150;
//     }
//     if((Sbs[4].x4 == Vhs[0].x0) && (Sbs[4].y4 == Vhs[0].y0) ){
//       Sbs[4].x4 = 850; Sbs[4].y4 = 250;
//     }
//     if((Sbs[5].x5 == Vhs[0].x0) && (Sbs[5].y5 == Vhs[0].y0) ){
//       Sbs[5].x5 = 950; Sbs[5].y5 = 250;
//     }
//     if((Sbs[6].x6 == Vhs[0].x0) && (Sbs[6].y6 == Vhs[0].y0) ){
//       Sbs[6].x6 = 850; Sbs[6].y6 = 350;
//     }
//     if((Sbs[7].x7 == Vhs[0].x0) && (Sbs[7].y7 == Vhs[0].y0) ){
//       Sbs[7].x7 = 950; Sbs[7].y7 = 350;
//       }
//     }
//   }

bool placerad1=true;
int pjäsX = Raylib.GetMouseX(); int pjäsY = Raylib.GetMouseY();
for (int alla_pjäser = 0; alla_pjäser <= 12; alla_pjäser++)
{
    
    for (int q = 0; q < 1; q++)
    {
         if ((Raylib.GetMouseX() < Vhs[q].x + 50 && Raylib.GetMouseX() > Vhs[q].x-25 ) && (Raylib.GetMouseY() < Vhs[q].y + 75 && Raylib.GetMouseY() > Vhs[0].y - 25 )&&(placerad)){
        placerad1=true;
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vhs[q].x = Raylib.GetMouseX() -19;
       Vhs[q].y = Raylib.GetMouseY() - 30;
       placerad1=false;
    
    
if ((Skung.x < Vhs[q].x+50 && Skung.x > Vhs[q].x-25) &&
    (Skung.y < Vhs[0].y+75 && Skung.y > Vhs[0].y-25)&& placerad1)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
    {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }
    }
      }
    }
}



// if ((Raylib.GetMouseX() < Vhs[0].x0 + 50 && Raylib.GetMouseX() > Vhs[0].x0-25 ) && (Raylib.GetMouseY() < Vhs[0].y0 + 75 && Raylib.GetMouseY() > Vhs[0].y0 - 25 )){
        
//     if (Raylib.IsMouseButtonDown(MouseButton.Left)){
//       Vhs[0].x0 = Raylib.GetMouseX() -19;
//        Vhs[0].y0 = Raylib.GetMouseY() - 30;
//        placerad=false;
//     }
    
// if (Raylib.CheckCollisionRecs(VhRec, VhRec)&& placerad)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
//     {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
//         Skung.x= 825;
//         Skung.y= 20;
//          // bool dead;
//     // if (dead){
//     //     gameover
//     //     vitt parti vann
//     // }
//     }

    //   }

   

//    if (Vhs[1].y1 == -50) {
//         Vhs[1].y1 = 150;                              
//         Vhs[1].x1 = 350;                             
//       }
//    if ((mouseX < Vhs[1].x1 + 25 && mouseX > Vhs[1].x1 - 25) && (mouseY < Vhs[1].y1 + 50 && mouseY > Vhs[1].y1 - 50 )){
  
//     if (mousePressed ){
      
//       Vhs[1].x1 -=  100;      // Vhs[1].y1 är y-kordinaten för häst 2
//       Vhs[1].y1 -=  200;      // Vhs[1].x1 är x-kordinaten för häst 2
//   if((Sbs[3].x3 == Vhs[1].x1) && (Sbs[3].y3 == Vhs[1].y1) ){
//       Sbs[3].x3 = 950; Sbs[3].y3 = 150;
      
//   }
//   }
//   }

Raylib.EndDrawing();

}
