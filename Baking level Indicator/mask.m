function mask
clc;
close all;
clear;
we=0;
range=0;
storage=zeros([1 5]);

for ch=1:5
name=char('a'+(ch-1));
%name='a';
%save='y';
n=1;
for i=1:5
    
    %if(i==3)
     %  continue
    %end
    
w=int2str(i);
%Read Background Image
Background=imread('bg1.jpg');
Background=imresize(Background,[300 300]);

%Read Current Frame
CurrentFrame=imread(strcat(name,w,'.jpg'));
CurrentFrame=imresize(CurrentFrame,[300 300]);

org=CurrentFrame;
org=rgb2gray(org);


%Display Background and Foreground
figure;
subplot(2,3,1);imshow(Background);title('BackGround');
subplot(2,3,2);imshow(CurrentFrame);title('Current Frame');
%Convert RGB 2 HSV Color conversion
[Background_hsv]=round(rgb2hsv(Background));
[CurrentFrame_hsv]=round(rgb2hsv(CurrentFrame));

org_hsv=CurrentFrame_hsv;

Out = bitxor(Background_hsv,CurrentFrame_hsv);

%out_hsv=rgb2hsv(Out)
%figure,imshow(out_hsv);title('st');figure;


%Convert RGB 2 GRAY
Out=rgb2gray(Out);
%Read Rows and Columns of the Image
[rows columns]=size(Out);
%Convert to Binary Image
for i=1:rows
for j=1:columns

if Out(i,j) >0

BinaryImage(i,j)=1;

else

BinaryImage(i,j)=0;

end

end
end



%Apply Median filter to remove Noise
FilteredImage=medfilt2(BinaryImage,[5 5]);
mak=FilteredImage;


%Boundary Label the Filtered Image
[L num]=bwlabel(FilteredImage);

STATS=regionprops(L,'all');
cc=[];
removed=0;

%Remove the noisy regions
for i=1:num
dd=STATS(i).Area;

if (dd < 500)

L(L==i)=0;
removed = removed + 1;
num=num-1;

else

end

end

[L2 num2]=bwlabel(L);

% Trace region boundaries in a binary image.

[B,L,N,A] = bwboundaries(L2);

%Display results

subplot(2,3,3),imshow(L2);title('BackGround Detected');


%figure,subplot(3,1,1),imshow(L2);title('mask');
%subplot(3,1,2),imshow(org);title('org');

mak=uint8(mak);
imf = org.*mak;

subplot(2,3,4),imshow(imf);title('Masked Output');
subplot(2,3,5),imshow(org);title('Orginal grey scale');

%imwrite(imf,strcat(save,w,'.jpg'));


imf= uint8(255*mat2gray(imf));

sum=0;
n=0;
s=size(imf);
for i=1:s(1)
    for j=1:s(2)
        
        if(imf(i,j)>50)
            n=n+1;
            sum=(sum+double(org(i,j)));
            
        end
    end 
end


sum;
n;
st=s(1)*s(2);
mean=double(sum/n);
mean;
we=we+1;

m(we)=mean;

end
t=1:size(m');
figure,plot(t,m);

storage=[storage;m];

%range=range+1;
%rangenew=int2str(range);
%r1=strcat('A',rangenew);
%r2=strcat('F',rangenew);
%xlswrite('obs.xls',m,r1:r2);
m=0;
we=0;
end

%xlswrite('obs.xls',storage);
%xlsshow('obs.xls');
end