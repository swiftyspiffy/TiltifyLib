# TiltifyLib
Library intended to perform API calls to Tiltify and parse the responses into models that mimic the response structures.

## Usage
```csharp
using TiltifyLib;

private TiltifyLib.Core core;

core = new TiltifyLib.Core("5fa6406191582cd3f0ed183ccb6b8748");

var campaign = await core.GetCampaignAsync(); // gets campaign details
var donations = await core.GetDonationsAsync(10); // gets most recent 10 donations
var activities = await core.GetActivitiesAsync(); // gets campaign's activities
var levels = await core.GetLevelsAsync(); // gets campaign's levels
var rewards = awaitcore.GetRewardsAsync(); // gets campaign's rewards
```