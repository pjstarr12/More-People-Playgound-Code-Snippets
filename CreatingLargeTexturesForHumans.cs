//if you make an upscaled human texture, you may notice that it looks wacky.
//that is because it is only reading 18 x 79 of the texture
//to make your upscaled human texture work, you first need to know how much you upscaled it by
//what i did, is i made it go from 18 x 79 to 180 x 790 (multiplied it by 10)
//so in your code where you make your items in the SetBodyTexture function, add another comma and put the number you upscaled the original texture by

PersonBehaviour.SetBodyTextures(skin, flesh, bone, 10); //(its 10 for me, because i made my texture 10x bigger then the original)
