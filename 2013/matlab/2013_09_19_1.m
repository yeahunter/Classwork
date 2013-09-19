format long
osszeg=1;
for i=3:4:100000000
    osszeg=osszeg - 1/i;
    i=i+2;
    osszeg=osszeg + 1/i;
end
osszeg*4