# Bird_Demo

# I'M PANICKING!!!! PLEASE FIX THESE ISSUES! I DON'T KNOW WHY IT'S DOING THIS????!!!!
- Character isn't moving correctly
- I only seem to be able to find robins for some reason
- I can seeing go into negative money
- I didn't have time to implement the bird house at all
- I've received feedback that it's too difficult to find the bird watching locations!
- Also I don't know if any of the values are values are properly set anymore! More testing needs to be done to make sure all values line up with the tables below.

## Premise: 
You are a birdwatcher and you have a camera. You can sell photos of birds that you find to make more money to buy upgrades for your camera, as well as better gear for finding rarer and more beautiful birds. Pictures of rarer and more beautiful birds and their feathers sell for more money.

## Main Classes

### Player
- Wallet
- Camera
- Gear

### Camera
- Level 1: Fixed Lens
- Level 2: 2x Zoom
- Level 3: 4x Zoom
  
*The more dangerous the bird, the further you need to take the picture from; if you try to take a picture underprepared, you get hurt and lose 10% of your current money.*

### Gear
- Level 1: Standard Clothes
- Level 2: Camo Shirt
- Level 3: Ghillie Suit
  
*The more skittish the bird, the stealthier you need to be.*

### Bird
- Name
- Capture Requirements
- Price
- Appearance Probability
- Description

### Flora Cover
- Birds it can contain
- Bird Contained

## Camera
| Level       | Description                                    |
|-------------|------------------------------------------------|
| 1           | Fixed Lens                                     |
| 2           | 2x Zoom                                        |
| 3           | 4x Zoom                                        |

## Gear
| Level       | Description                                    |
|-------------|------------------------------------------------|
| 1           | Standard Clothes                              |
| 2           | Camo Shirt                                    |
| 3           | Ghillie Suit                                   |


## Bird Info
| Name         | Camera Requirement | Stealth Requirement | Price    | Appearance Prob Weight |
|--------------|--------------------|---------------------|----------|------------------------|
| Robin        | 1                  | 1                   | $10      | 15                     |
| Parrot       | 1                  | 2                   | $50      | 6                      |
| Falcon       | 2                  | 2                   | $100     | 4                      |
| Harpy Eagle  | 2                  | 3                   | $150     | 4                      |
| Ostrich      | 3                  | 2                   | $300     | 5                      |
| Cassowary    | 3                  | 3                   | $600     | 2                      |

*Probability of Appearance of Bird A = Appearance Probability Weight of Bird A / Sum of all appearance probability weights of the birds that can appear in this specific flora cover*

## Cover Info
| Name          | Birds it may contain                  |
|---------------|---------------------------------------|
| Shrub         | Robin, Parrot, Falcon                 |
| Tree          | Robin, Parrot, Falcon, Harpy Eagle    |
| Grassy Field  | Ostrich, Cassowary                    |
| Bird House    | Robin                                 |

## Upgrade Info
| Name          | Price   |
|---------------|---------|
| Camera 2x zoom| $100    |
| Camera 4x zoom| $300    |
| Camo Suit     | $30     |
| Ghillie Suit  | $120    |
