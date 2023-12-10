------ DataBase ------
CREATE DATABASE Pokemon;
----------------------------------------------------------------------------------------------------------------

USE Pokemon;

------ TABLE TYPE ELEMEMT ------
CREATE TABLE TypeElement (
	typeElementID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	typeElementName VARCHAR(50) NOT NULL
);

INSERT INTO TypeElement VALUES ('Fairy');	--1
INSERT INTO TypeElement VALUES ('Steel');	--2
INSERT INTO TypeElement VALUES ('Dark');	--3
INSERT INTO TypeElement VALUES ('Dragon');	--4
INSERT INTO TypeElement VALUES ('Ghost');	--5
INSERT INTO TypeElement VALUES ('Rock');	--6
INSERT INTO TypeElement VALUES ('Bug');		--7
INSERT INTO TypeElement VALUES ('Psychc');	--8
INSERT INTO TypeElement VALUES ('Flying');	--9
INSERT INTO TypeElement VALUES ('Ground');	--10	
INSERT INTO TypeElement VALUES ('Poison');	--11
INSERT INTO TypeElement VALUES ('Fight');	--12
INSERT INTO TypeElement VALUES ('Ice');		--13
INSERT INTO TypeElement VALUES ('Grass');	--14
INSERT INTO TypeElement VALUES ('Electr');	--15
INSERT INTO TypeElement VALUES ('Water');	--16
INSERT INTO TypeElement VALUES ('Fire');	--17
INSERT INTO TypeElement VALUES ('Normal');	--18
----------------------------------------------------------------------------------------------------------------

------ TABLE TYPE MOVEMENT ------
CREATE TABLE TypeMovement (
	typeMovementID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	typeMovementName VARCHAR(50) NOT NULL
);

INSERT INTO TypeMovement VALUES ('Attack');
INSERT INTO TypeMovement VALUES ('Defense');
----------------------------------------------------------------------------------------------------------------

------ TABLE ATTACK ------
CREATE TABLE Movement (
	movementID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	movementName VARCHAR(50) NOT NULL,
	movementPower INT NOT NULL,
	typeMovementID INT NOT NULL FOREIGN KEY REFERENCES TypeMovement(typeMovementID)
);

INSERT INTO Movement VALUES ('Scratch', 40, 1);
INSERT INTO Movement VALUES ('Cut', 50, 1);
INSERT INTO Movement VALUES ('Protect', 0, 2);
INSERT INTO Movement VALUES ('Detect', 0, 2);
----------------------------------------------------------------------------------------------------------------

------ TABLE POKEMON ------
CREATE TABLE Pokemon (
	pokemonID INT NOT NULL PRIMARY KEY,
	pokemonName VARCHAR(50) NOT NULL,
	pokemonDescription VARCHAR(200) NOT NULL,
	typeElementOneID INT NOT NULL FOREIGN KEY REFERENCES TypeElement(typeElementID),
	typeElementTwoID INT FOREIGN KEY REFERENCES TypeElement(typeElementID),
	movementOneID INT NOT NULL FOREIGN KEY REFERENCES Movement(movementID),
	movementTwoID INT NOT NULL FOREIGN KEY REFERENCES Movement(movementID),
	movementThreeID INT NOT NULL FOREIGN KEY REFERENCES Movement(movementID),
	movementFourID INT NOT NULL FOREIGN KEY REFERENCES Movement(movementID)
);

INSERT INTO Pokemon VALUES (722, 'Rowlet', 'It sends its feathers, which are as sharp as blades, flying in attack. Its legs are strong, so its kicks are also formidable.', 14, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (723, 'Dartrix', 'This narcissistic Pokémon is a clean freak. If you dont groom it diligently, it will stop listening to you.', 14, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (724, 'Decidueye', 'It nocks its arrow quills and shoots them at opponents. When it simply cant afford to miss, it tugs the vine on its head to improve its focus.', 14, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (725, 'Litten', 'If you try too hard to get close to it, it wont open up to you. Even if you do grow close, giving it too much affection is still a no-no.', 17, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (726, 'Torracat', 'It can act spoiled if it grows close to its Trainer. A powerful Pokémon, its sharp claws can leave its Trainers whole body covered in scratches.', 17, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (727, 'Incineroar', 'Although its rough mannered and egotistical, it finds beating down unworthy opponents boring. It gets motivated for stronger opponents.', 17, 3, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (728, 'Popplio', 'The balloons it inflates with its nose grow larger and larger as it practices day by day.', 16, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (729, 'Brionne', 'It gets excited when it sees a dance it doesnt know. This hard worker practices diligently until it can learn that dance.', 16, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (730, 'Primarina', 'To Primarina, every battle is a stage. It takes down its prey with beautiful singing and dancing.', 16, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (731, 'Pikipek', 'It pecks at trees with its hard beak. You can get some idea of its mood or condition from the rhythm of its pecking.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (732, 'Trumbeak', 'It can bend the tip of its beak to produce over a hundred different cries at will.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (733, 'Toucannon', 'They smack beaks with others of their kind to communicate. The strength and number of hits tell each other how they feel.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (734, 'Yungoos', 'Its stomach fills most of its torso. It wanders the same path every day, searching for fresh food.', 18, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (735, 'Gumshoos', 'Once it finds signs of prey, it will patiently stake out the location, waiting until the sun goes down.', 18, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (736, 'Grubbin', 'Its natural enemies, like Rookidee, may flee rather than risk getting caught in its large mandibles that can snap thick tree branches.', 7, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (737, 'Charjabug', 'While its durable shell protects it from attacks, Charjabug strikes at enemies with jolts of electricity discharged from the tips of its jaws.', 7, 15, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (738, 'Vikavolt', 'It builds up electricity in its abdomen, focuses it through its jaws, and then fires the electricity off in concentrated beams.', 7, 15, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (739, 'Crabrawler', 'This Pokémon punches trees and eats the berries that drop down, training itself and getting food at the same time.', 12, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (740, 'Crabominable', 'The detached pincers of these Pokémon are delicious. Some Trainers bring Lechonk into the mountains just to search for them.', 12, 13, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (741, 'Oricorio', 'This Pokémon is incredibly popular, possibly because its passionate dancing is a great match with the temperament of Paldean people.', 17, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (742, 'Cutiefly', 'Nectar and pollen are its favorite fare. You can find Cutiefly hovering around Gossifleur, trying to get some of Gossifleur’s pollen.', 7, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (743, 'Ribombee', 'It makes pollen puffs from pollen and nectar. The puffs’ effects depend on the type of ingredients and how much of each one is used.', 7, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (744, 'Rockruff', 'This Pokémon is very friendly when it’s young. Its disposition becomes vicious once it matures, but it never forgets the kindness of its master.', 6, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (745, 'Lycanroc', 'Lycanroc attacks its prey with its sharp claws and fangs. It loyally obeys the instructions of a Trainer it trusts.', 6, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (746, 'Wishiwashi', 'Individually, they’re incredibly weak. It’s by gathering up into schools that they’re able to confront opponents.', 16, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (747, 'Mareanie', 'This Pokémon wanders the seaside looking for food. It often gets electric shocks from broken Pincurchin spines that it tries to eat.', 11, 16, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (748, 'Toxapex', 'This Pokémon lives within a dome made by its own legs. Toxapex monitors its surroundings by sensing the flow of the tide through its spikes.', 11, 16, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (749, 'Mudbray', 'This Pokémon covers itself in mud that it has regurgitated. The mud won’t dry out even if it’s exposed to the sun for a long time.', 10, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (750, 'Mudsdale', 'This Pokémon has been treasured not just for its physical labor but also because it produces high-quality mud used for making pottery.', 10, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (751, 'Dewpider', 'It forms a water bubble at the rear of its body and then covers its head with it. Meeting another Dewpider means comparing water-bubble sizes.', 16, 7, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (752, 'Araquanid', 'It launches water bubbles with its legs, drowning prey within the bubbles. This Pokémon can then take its time to savor its meal.', 16, 7, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (753, 'Fomantis', 'Fomantis hates having its naps interrupted. It fires off beams using energy it gathers by bathing in the sun.', 14, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (754, 'Lurantis', 'By masquerading as a bug Pokémon, it lowers the guard of actual bug Pokémon lured in by a scent of sweet flowers. Its sickles bring them down.', 14, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (755, 'Morelull', 'Pokémon living in the forest eat the delicious caps on Morelull’s head. The caps regrow overnight.', 14, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (756, 'Shiinotic', 'Its flickering spores lure in prey and put them to sleep. Once this Pokémon has its prey snoozing, it drains their vitality with its fingertips.', 14, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (757, 'Salandit', 'It taunts its prey and lures them into narrow, rocky areas where it then sprays them with toxic gas to make them dizzy and take them down.', 11, 17, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (758, 'Salazzle', 'Salazzle makes its opponents light-headed with poisonous gas, then captivates them with alluring movements to turn them into loyal servants.', 11, 17, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (759, 'Stufful', 'Its fluffy fur is a delight to pet, but carelessly reaching out to touch this Pokémon could result in painful retaliation.', 18, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (760, 'Bewear', 'Once it accepts you as a friend, it tries to show its affection with a hug. Letting it do that is dangerous—it could easily shatter your bones.', 18, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (761, 'Bounsweet', 'Its sweat is sweet, like syrup made from boiled- down fruit. Because of this, Bounsweet was highly valued in the past, when sweeteners were scarce.', 14, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (762, 'Steenee', 'Steenee spreads a sweet scent that makes others feel invigorated. This same scent is popular for antiperspirants.', 14, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (763, 'Tsareena', 'This Pokémon is proud and aggressive. However, it is said that a Tsareena will instantly become calm if someone touches the crown on its calyx.', 14, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (764, 'Comfey', 'It stretches sticky vines out from its head and picks flowers to adorn itself with. When it doesnt have any flowers, it feels uneasy.', 1, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (765, 'Oranguru', 'People used to mistake Oranguru for a human when they saw it issue command after command to the other Pokémon of the forest.', 18, 8, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (766, 'Passimian', 'This Pokémon battles by throwing hard berries. It won’t obey a Trainer who throws Poké Balls without skill.', 12, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (767, 'Wimpod', 'It’s nature’s cleaner—it eats anything and everything, including garbage and rotten things. The ground near its nest is always clean.', 7, 16, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (768, 'Golisopod', 'It will do anything to win, taking advantage of every opening and finishing opponents off with the small claws on its front legs.', 7, 16, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (769, 'Sandygast', 'If it loses its shovel, it will stick something else— like a branch—in its head to make do until it finds another shovel.', 5, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (770, 'Palossand', 'The terrifying Palossand drags smaller Pokémon into its sandy body. Once its victims are trapped, it drains them of their vitality whenever it pleases.', 5, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (771, 'Pyukumuku', 'It lives in warm, shallow waters. If it encounters a foe, it will spit out its internal organs as a means to punch them.', 16, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (772, 'Type: Null', 'Rumor has it that the theft of top-secret research notes led to a new instance of this Pokémon being created in the Galar region.', 18, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (773, 'Silvally', 'A solid bond of trust between this Pokémon and its Trainer awakened the strength hidden within Silvally. It can change its type at will.', 18, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (774, 'Minior', 'It lives in the ozone layer, where it becomes food for stronger Pokémon. When it tries to run away, it falls to the ground.', 6, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (775, 'Komala', 'Komala spends its entire life sleeping. It feeds on leaves that contain a potent poison only Komala can break down.', 18, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (776, 'Turtonator', 'Explosive substances coat the shell on its back. Enemies that dare attack it will be blown away by an immense detonation.', 17, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (777, 'Togedemaru', 'With the long hairs on its back, this Pokémon takes in electricity from other electric Pokémon. It stores what it absorbs in an electric sac.', 15, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (778, 'Mimikyu', 'This Pokémon lives in dark places untouched by sunlight. When it appears before humans, it hides itself under a cloth that resembles a Pikachu.', 5, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (779, 'Bruxish', 'It grinds its teeth with great force to stimulate its brain. It fires the psychic energy created by this process from the protuberance on its head.', 16, 8, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (780, 'Drampa', 'The mountains it calls home are nearly two miles in height. On rare occasions, it descends to play with the children living in the towns below.', 18, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (781, 'Dhelmise', 'After a piece of seaweed merged with debris from a sunken ship, it was reborn as this ghost Pokémon.', 5, 14, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (782, 'Jangmo-o', 'They learn to fight by smashing their head scales together. The dueling strengthens both their skills and their spirits.', 4, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (783, 'Hakamo-o', 'The scaleless, scarred parts of its body are signs of its strength. It shows them off to defeated opponents.', 4, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (784, 'Kommo-o', 'It clatters its tail scales to unnerve opponents. This Pokémon will battle only those who stand steadfast in the face of this display.', 4, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (785, 'Tapu Koko', 'Although its called a guardian deity, if a person or Pokémon puts it in a bad mood, it will become a malevolent deity and attack.', 15, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (786, 'Tapu Lele', 'It heals the wounds of people and Pokémon by sprinkling them with its sparkling scales. This guardian deity is worshiped on Akala.', 8, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (787, 'Tapu Bulu', 'Although its called a guardian deity, its violent enough to crush anyone it sees as an enemy.', 14, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (788, 'Tapu Fini', 'This guardian deity of Poni Island manipulates water. Because it lives deep within a thick fog, it came to be both feared and revered.', 16, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (789, 'Cosmog', 'Even though its helpless, gaseous body can be blown away by the slightest breeze, it doesnt seem to care.', 8, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (790, 'Cosmoem', 'The king who ruled Alola in times of antiquity called it the cocoon of the stars and built an altar to worship it.', 8, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (791, 'Solgaleo', 'Sometimes the result of its opening an Ultra Wormhole is that energy and life-forms from other worlds are called here to this world.', 8, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (792, 'Lunala', 'Records of it exist in writings from long, long ago, where it was known by the name the beast that calls the moon.', 8, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (793, 'Nihilego', 'A life-form from another world, it was dubbed a UB and is thought to produce a strong neurotoxin.', 6, 11, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (794, 'Buzzwole', 'Although its alien to this world and a danger here, its apparently a common organism in the world where it normally lives.', 7, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (795, 'Pheromosa', 'A life-form that lives in another world, its body is thin and supple, but it also possesses great power.', 7, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (796, 'Xurkitree', 'Although its alien to this world and a danger here, its apparently a common organism in the world where it normally lives.', 15, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (797, 'Celesteela', 'One of the dangerous UBs, high energy readings can be detected coming from both of its huge arms.', 2, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (798, 'Kartana', 'This Ultra Beasts body, which is as thin as paper, is like a sharpened sword.', 14, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (799, 'Guzzlord', 'Although its alien to this world and a danger here, its apparently a common organism in the world where it normally lives.', 3, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (800, 'Necrozma', 'It looks somehow pained as it rages around in search of light, which serves as its energy. Its apparently from another world.', 8, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (801, 'Magearna', 'It synchronizes its consciousness with others to understand their feelings. This faculty makes it useful for taking care of people.', 2, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (802, 'Marshadow', 'It slips into the shadows of others and mimics their powers and movements. As it improves, it becomes stronger than those its imitating.', 12, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (803, 'Poipole', 'This Ultra Beast is well enough liked to be chosen as a first partner in its own world.', 11, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (804, 'Naganadel', 'It stores hundreds of liters of poisonous liquid inside its body. It is one of the organisms known as UBs.', 11, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (805, 'Stakataka', 'It appeared from an Ultra Wormhole. Each one appears to be made up of many life-forms stacked one on top of each other.', 6, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (806, 'Blacephalon', 'It slithers toward people. Then, without warning, it triggers the explosion of its own head. Its apparently one kind of Ultra Beast.', 17, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (807, 'Zeraora', 'It electrifies its claws and tears its opponents apart with them. Even if they dodge its attack, theyll be electrocuted by the flying sparks.', 15, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (808, 'Meltan', 'It melts particles of iron and other metals found in the subsoil, so it can absorb them into its body of molten steel.', 2, null, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (809, 'Melmetal', 'Revered long ago for its capacity to create iron from nothing, for some reason it has come back to life after 3,000 years.', 2, null, 1, 2, 3, 4);
----------------------------------------------------------------------------------------------------------------

------ TABLE TEAM ------
CREATE TABLE Team(
	teamID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	pokemonOneID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID),
	pokemonTwoID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID),
	pokemonThreeID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID),
	pokemonFourID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID),
	pokemonFiveID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID),
	pokemonSixID INT NOT NULL FOREIGN KEY REFERENCES Pokemon(pokemonID)
);

----------------------------------------------------------------------------------------------------------------

------ TABLE PLAYER ------
CREATE TABLE Player (
	playerID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	playerName VARCHAR(50) NOT NULL,
	teamID INT NOT NULL FOREIGN KEY REFERENCES Team(teamID)
);

----------------------------------------------------------------------------------------------------------------

------ TABLE ARENA ------
CREATE TABLE Arena (
	arenaID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	typeElementID INT NOT NULL FOREIGN KEY REFERENCES TypeElement(typeElementID)
);

INSERT INTO Arena VALUES (1);
INSERT INTO Arena VALUES (2);
INSERT INTO Arena VALUES (3);
INSERT INTO Arena VALUES (4);
INSERT INTO Arena VALUES (5);
INSERT INTO Arena VALUES (6);
INSERT INTO Arena VALUES (7);
INSERT INTO Arena VALUES (8);
INSERT INTO Arena VALUES (9);
INSERT INTO Arena VALUES (10);
INSERT INTO Arena VALUES (11);
INSERT INTO Arena VALUES (12);
INSERT INTO Arena VALUES (13);
INSERT INTO Arena VALUES (14);
INSERT INTO Arena VALUES (15);
INSERT INTO Arena VALUES (16);
INSERT INTO Arena VALUES (17);
INSERT INTO Arena VALUES (18);
----------------------------------------------------------------------------------------------------------------

------ TABLE TOURNAMENT ------
CREATE TABLE Tournament (
	tournamentID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	winnerID INT NOT NULL FOREIGN KEY REFERENCES Player(playerID)
);

----------------------------------------------------------------------------------------------------------------

------ TABLE LOG ------
CREATE TABLE "Log" (
	logID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	logDescription VARCHAR(200) NOT NULL
);

----------------------------------------------------------------------------------------------------------------

------ TABLE BATTLE ------
CREATE TABLE Battle (
	battleID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	tournamentID INT NOT NULL FOREIGN KEY REFERENCES Tournament(tournamentID),
	arenaID INT NOT NULL FOREIGN KEY REFERENCES Arena(arenaID),
	playerOneID INT NOT NULL FOREIGN KEY REFERENCES Player(playerID),
	playerTwoID INT NOT NULL FOREIGN KEY REFERENCES Player(playerID),
	winnerID INT NOT NULL FOREIGN KEY REFERENCES Player(playerID),
	logID INT NOT NULL FOREIGN KEY REFERENCES "Log"(logID)
);

----------------------------------------------------------------------------------------------------------------