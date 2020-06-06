# HamiltonianRide
Game development course project

We made a HamiltonianRide game. 
For game objects we have the road (sraight and turn tiles) with edges that has box collider to set boundries for the player's car, the player's car, the houses the player needs to deliver that represent the vertices of the hamiltonian path and the [covid-19](/HamiltonianRide/Assets/Scripts/Heart.cs) in gas form.  
The [house](/HamiltonianRide/Assets/Scripts/Vertex.cs) has an edge collider in a straight line at the front. This is a trick to trigger a collision between the player and the house even though there is no real coliision. The player's [car](/HamiltonianRide/Assets/Scripts/move.cs) has rigid body and box collider and gravity set to zero.  
They are prefabs to make building levels easier.  Last but not least we have [game manager](/HamiltonianRide/Assets/Scripts/GameManager.cs) to manage the UI and the game progress.  
In the GameManager, at the start function he counts the number of vertices using the GameObject FindGameObjectsWithTag function. The house prefab is tagged as a vertex. Each time the player collides a house, it changes the house's sprite and calls a function that notifies the GameManager and it updates the game accordingly. When the number of vertices becomes zero, a UI panel pauses the game and infroms the player he won the level.

At the start of each level the player starts at the starting vertex we pre define and needs to calculate the path and the Covid-19 object which also pre defined at a strategic location that will provide some level of difficulty that will increase each level or maybe by choice at the start of the game. 
The player controls are the arrow keys. The player can't exit the path due to the colliders at the edges so for his benefit he should stay in line and focus at the road. If the player can't go back to already visited house (vertex) as he will lose due to visitting the same vertex twice and violating the hamiltonian path rule. The Covid-19 object starts at some point on the map and gets bigger each second so the player must hurry and avoid tacking the edges so he can keep riding at full speed.  
We need to add minimap. it maybe seems not needed for the first level but as the path will get more complicated it will be the most helpful tool he can get so he won't get frustrated as he keep leveling up. 
