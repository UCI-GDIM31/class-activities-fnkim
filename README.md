# in-class-activities
## Devlogs
### W1
When you move the camera out of the cat, the camera stays still and you can see the cat moving around independently.
This is because the camera is no longer attached to the cat, and the screen will not move along with the cat.

### W2
Why are the r, g, and b variables floats instead of ints, bools, or strings?
Why is the _bounce variable an int instead of a float, bool, or string?
The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?

The r, g, and b variables are floats because they are fractional numbers, not whole numbers, not words, and not in a true or false state. Meanwhile,
the _bounce variable is an int because it checks how many bounces there are, which can only be a whole number. Wgen I accidentally uncommented r += 0.1f
in step 2, the game wouldn't run because there was no semicolon.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 