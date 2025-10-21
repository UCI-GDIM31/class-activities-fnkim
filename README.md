# in-class-activities
## Devlogs
### W1
When you move the camera out of the cat, the camera stays still and you can see the cat moving around independently.
This is because the camera is no longer attached to the cat, and the screen will not move along with the cat.

### W2
The r, g, and b variables are floats because they are fractional numbers, not whole numbers, not words, and not in a true or false state. Meanwhile,
the _bounce variable is an int because it checks how many bounces there are, which can only be a whole number. Wgen I accidentally uncommented r += 0.1f
in step 2, the game wouldn't run because there was no semicolon.

### W3
In the visual novel, the parameters would be an int variable which checks the player's friendship level with the character, and a boolean variable that checks the flag of if the player knows the character's secret. The return type would be a string that contains the text response of the NPC.

### W4
Table 11

Line 17: _isGrounded is a member variable and its type is bool
Line 28: it's checking for input (space key) and the boolean type _isGrounded
Line 32: sets the boolean _isGrounded as false

The solution I came up with for the collider activity was to add Rigidbodies to the cat and the ball. This is because these are the objects that need physics in which they collide with things and don't go through them. I checked Is Trigger on the goal, since that is the object that needs to be tested if it is hit, and it needs to be able to be passed through.

My game did not work perfectly the first time I tested it, in regards to the timer text updating. I was updating the variable, but I forgot to add the code to update the text on the screen as well. I fixed this by adding "_timeText.text = _timerNumber.ToString();".


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 