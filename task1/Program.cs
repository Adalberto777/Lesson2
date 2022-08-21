int a1 = 15;
int b1 = 16;
int c1 = 22;
int a2 = 1125;
int b2 = 16;
int c2 = 2;
int a3 = 125;
int b3 = 6;
int c3 = 222;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);