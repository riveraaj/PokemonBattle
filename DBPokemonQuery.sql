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

INSERT INTO Pokemon VALUES (387, 'Turtwig', 'This Pokémon becomes more energetic the more sunlight there is. The part resembling a shell is similar to silt and is slightly damp and warm to the touch.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (388, 'Grotle', 'It lives along water in forests. In the daytime, it leaves the forest to sunbathe its treed shell.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (389, 'Torterra', 'Small Pokémon occasionally gather on its unmovingback to begin building their nests.', 14, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (390, 'Chimchar', 'Its fiery rear end is fueled by gas made in its belly. Even rain cant extinguish the fire.', 17, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (391, 'Monferno', 'It skillfully controls the intensity of the fire on itstail to keep its foes at an ideal distance.', 17, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (392, 'Infernape', 'Its crown of fire is indicative of its fiery nature. It is beaten by none in terms of quickness.', 17, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (393, 'Piplup', 'It doesnt like to be taken care of. Its difficult tobond with since it wont listen to its Trainer.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (394, 'Prinplup', 'It lives alone, away from others. Apparently, everyone of them believes it is the most important.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (395, 'Empoleon', 'It swims as fast as a jet boat. The edges of itswings are sharp and can slice apart drifting ice.', 16, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (396, 'Starly', 'They flock around mountains and fields, chasing after bug Pokémon. Their singing is noisy and annoying.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (397, 'Staravia', 'Recognizing their own weakness, they always live in a group. When alone, a Staravia cries noisily.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (398, 'Staraptor', 'When Staravia evolve into Staraptor, they leave the flock to live alone. They have sturdy wings.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (399, 'Bidoof', 'With nerves of steel, nothing can perturb it. It ismore agile and active than it appears.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (400, 'Bibarel', 'It busily makes its nest with stacks of branches androots it has cut up with its sharp incisors.', 18, 16, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (401, 'Kricketot', 'Its legs are short. Whenever it stumbles, its stiff antennae clack with a xylophone-like sound.', 7, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (402, 'Kricketune', 'By allowing its cry to resonate in the hollow of its belly, it produces a captivating sound.', 7, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (403, 'Shinx', 'The extension and contraction of its muscles generates electricity. It glows when in trouble.', 15, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (404, 'Luxio', 'Strong electricity courses through the tips of its sharp claws. A light scratch causes fainting in foes.', 15, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (405, 'Luxray', 'It can see clearly through walls to track down its prey and seek its lost young.', 15, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (406, 'Budew', 'The pollen it releases contains poison. If this Pokémon is raised on clean water, the poison’s toxicity is increased.', 14, 11, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (407, 'Roserade', 'After captivating opponents with its sweet scent, it lashes them with its thorny whips.', 14, 11, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (408, 'Cranidos', 'A primeval Pokémon, it possesses a hard and sturdy skull, lacking any intelligence within.', 6, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (409, 'Rampardos', 'In ancient times, people would dig up fossils of this Pokémon and use its skull, which is harder than steel, to make helmets.', 6, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (410, 'Shieldon', 'A mild-mannered, herbivorous Pokémon, it used its face to dig up tree roots to eat. The skin on its face was plenty tough.', 6, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (411, 'Bastiodon', 'The bones of its face are huge and hard, so they were mistaken for its spine until after this Pokémon was successfully restored.', 6, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (412, 'Burmy', 'To shelter itself from cold, wintry winds, it coversitself with a cloak made of twigs and leaves.', 7, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (413, 'Wormadam', 'Its appearance changes depending on where itevolved. The materials on hand become a part ofits body.', 7, 14, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (414, 'Mothim', 'It loves the honey of flowers and steals honeycollected by Combee.', 7, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (415, 'Combee', 'At night, Combee sleep in a group of about a hundred, packed closely together in a lump.', 7, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (416, 'Vespiquen', 'It houses its colony in cells in its body and releases various pheromones to make those grubs do its bidding.', 7, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (417, 'Pachirisu', 'It’s one of the kinds of Pokémon with electric cheek pouches. It shoots charges from its tail.', 15, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (418, 'Buizel', 'It spins its two tails like a screw to propel itself through water. The tails also slice clinging seaweed.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (419, 'Floatzel', 'With its flotation sac inflated, it can carry people on its back. It deflates the sac before it dives.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (420, 'Cherubi', 'It nimbly dashes about to avoid getting pecked by bird Pokémon that would love to make off with its small, nutrient-rich storage ball.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (421, 'Cherrim', 'As a bud, it barely moves. It sits still, placidly waiting for sunlight to appear.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (422, 'Shellos', 'It used to have a shell on its back long ago. This species is closely related to Pokémon like Shellder.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (423, 'Gastrodon', 'They normally inhabit rocky seashores, but in times of continuous rain, they can sometimes be found in the mountains, far from the sea.', 16, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (424, 'Ambipom', 'In their search for comfortable trees, they get into territorial disputes with groups of Passimian. They win about half the time.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (425, 'Drifloon', 'It is whispered that any child who mistakes Drifloon for a balloon and holds on to it could wind up missing.', 5, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (426, 'Drifblim', 'It can generate and release gas within its body. That’s how it can control the altitude of its drift.', 5, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (427, 'Buneary', 'Its arms and legs are weak, but when it rolls its ears up tight and then unleashes them with its full force, it can smash boulders to dust.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (428, 'Lopunny', 'Lopunny regrows its coat twice a year. Mufflers and hats made from its fur are really warm.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (429, 'Mismagius', 'Its cry sounds like an incantation. It is said the cry may rarely be imbued with happiness-giving power.', 5, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (430, 'Honchkrow', 'It is merciless by nature. It is said that it never forgives the mistakes of its Murkrow followers.', 3, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (431, 'Glameow', 'It claws if displeased and purrs when affectionate. Its fickleness is very popular among some.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (432, 'Purugly', 'It would claim another Pokémons nest as its ownif it finds a nest sufficiently comfortable.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (433, 'Chingling', 'Each time it hops, it makes a ringing sound. It deafens foes by emitting high-frequency cries.', 8, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (434, 'Stunky', 'It sprays a foul fluid from its rear. Its stench spreads over a mile radius, driving Pokémon away.', 11, 3, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (435, 'Skuntank', 'It attacks by spraying a horribly smelly fluid from the tip of its tail. Attacks from above confound it.', 11, 3, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (436, 'Bronzor', 'Ancient people believed that the pattern on Bronzor’s back contained a mysterious power.', 2, 8, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (437, 'Bronzong', 'In ages past, this Pokémon was revered as a bringer of rain. It was found buried in the ground.', 2, 8, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (438, 'Bonsly', 'In order to adjust the level of fluids in its body, it exudes water from its eyes. This makes it appear to be crying.', 6, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (439, 'Mime Jr.', 'It mimics everyone it sees, but it puts extra effort into copying the graceful dance steps of Mr. Rime as practice.', 8, 1, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (440, 'Happiny', 'It carries a round, white rock in its belly pouch. If it gets along well with someone, it will sometimes give that person the rock.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (441, 'Chatot', 'It mimics the cries of other Pokémon to trick theminto thinking its one of them. This way they wontattack it.', 18, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (442, 'Spiritomb', 'Its constant mischief and misdeeds resulted in it being bound to an Odd Keystone by a mysterious spell.', 5, 3, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (443, 'Gible', 'It skulks in caves, and when prey or an enemy passes by, it leaps out and chomps them. The force of its attack sometimes chips its teeth.', 4, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (444, 'Gabite', 'In rare cases, it molts and sheds its scales. Medicine containing its scales as an ingredient will make a weary body feel invigorated.', 4, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (445, 'Garchomp', 'It is said that when one runs at high speed, its wings create blades of wind that can fell nearby trees.', 4, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (446, 'Munchlax', 'Stuffing itself with vast amounts of food is its only concern. Whether the food is rotten or fresh, yummy or tasteless—it does not care.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (447, 'Riolu', 'They communicate with one another using their auras. They are able to run all through the night.', 12, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (448, 'Lucario', 'It’s said that no foe can remain invisible to Lucario, since it can detect auras—even those of foes it could not otherwise see.', 12, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (449, 'Hippopotas', 'It shuts its nostrils tight, then travels through sand as if walking. They form colonies of around 10.', 10, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (450, 'Hippowdon', 'It is surprisingly quick to anger. It holds its mouth agape as a display of its strength.', 10, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (451, 'Skorupi', 'After burrowing into the sand, it waits patiently for prey to come near. This Pokémon and Sizzlipede share common descent.', 11, 7, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (452, 'Drapion', 'Its poison is potent, but it rarely sees use. This Pokémon prefers to use physical force instead, going on rampages with its car-crushing strength.', 11, 3, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (453, 'Croagunk', 'Inflating its poison sacs, it fills the area with an odd sound and hits flinching opponents with a poison jab.', 11, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (454, 'Toxicroak', 'Swaying and dodging the attacks of its foes, it weaves its flexible body in close, then lunges out with its poisonous claws.', 11, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (455, 'Carnivine', 'It attracts prey with its sweet-smelling saliva, thenchomps down. It takes a whole day to eat prey.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (456, 'Finneon', 'The line running down its side can store sunlight. It shines vividly at night.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (457, 'Lumineon', 'With its shining light, it lures its prey close. However, the light also happens to attract ferocious fish Pokémon—its natural predators.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (458, 'Mantyke', 'Mantyke living in Galar seem to be somewhat sluggish. The colder waters of the seas in this region may be the cause.', 16, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (459, 'Snover', 'During cold seasons, it migrates to the mountain’s lower reaches. It returns to the snow-covered summit in the spring.', 14, 13, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (460, 'Abomasnow', 'It lives a quiet life on mountains that are perpetually covered in snow. It hides itself by whipping up blizzards.', 14, 13, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (461, 'Weavile', 'Evolution made it even more devious. It communicates by clawing signs in boulders.', 3, 13, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (462, 'Magnezone', 'As it zooms through the sky, this Pokémon seems to be receiving signals of unknown origin while transmitting signals of unknown purpose.', 15, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (463, 'Lickilicky', 'A contest is under way to determine which one can stick its tongue out the farthest. The current record is.. . more than 82 feet.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (464, 'Rhyperior', 'It can load up to three projectiles per arm into the holes in its hands. What launches out of those holes could be either rocks or Roggenrola.', 10, 6, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (465, 'Tangrowth', 'It ensnares prey by extending arms made of vines. Losing arms to predators does not trouble it.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (466, 'Electivire', 'It grips its tail, which spews electricity, and then beats down opponents with the power of its electrified fist.', 15, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (467, 'Magmortar', 'There are still quite a few factories that rely on the flames provided by Magmortar to process metals.', 17, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (468, 'Togekiss', 'These Pokémon are never seen anywhere near conflict or turmoil. In recent times, they’ve hardly been seen at all.', 1, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (469, 'Yanmega', 'It prefers to battle by biting apart foes headsinstantly while flying by at high speed.', 7, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (470, 'Leafeon', 'When you see Leafeon asleep in a patch of sunshine, you’ll know it is using photosynthesis to produce clean air.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (471, 'Glaceon', 'It can control its body temperature at will. This enables it to freeze the moisture in the atmosphere, creating flurries of diamond dust.', 13, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (472, 'Gliscor', 'It observes prey while hanging inverted frombranches. When the chance presents itself, it swoops!', 10, 9, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (473, 'Mamoswine', 'This Pokémon can be spotted in wall paintings from as far back as 10,000 years ago. For a while, it was thought to have gone extinct.', 13, 10, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (474, 'Porygon-Z', 'Its behavior is noticeably unstable, which is apparently due to the incompetence of the engineer who updated its programming.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (475, 'Gallade', 'When trying to protect someone, it extends its elbows as if they were swords and fights savagely.', 8, 12, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (476, 'Probopass', 'Although it can control its units known as Mini-Noses, they sometimes get lost and dont come back.', 6, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (477, 'Dusknoir', 'At the bidding of transmissions from the spirit world, it steals people and Pokémon away. No one knows whether it has a will of its own.', 5, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (478, 'Froslass', 'When it finds humans or Pokémon it likes, it freezes them and takes them to its chilly den, where they become decorations.', 13, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (479, 'Rotom', 'Its electricity-like body can enter some kinds of machines and take control in order to make mischief.', 15, 5, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (480, 'Uxie', 'Known as the Being of Knowledge, it is said that it can wipe out the memory of those who see its eyes.', 8, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (481, 'Mesprit', 'Known as the Being of Emotion, it taught humans the nobility of sorrow, pain, and joy.', 8, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (482, 'Azelf', 'Known as the Being of Willpower, it sleeps at the bottom of a lake to keep the world in balance.', 8, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (483, 'Dialga', 'A Pokémon spoken of in legend. It is said that timebegan moving when Dialga was born.', 2, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (484, 'Palkia', 'It is said to live in a gap in the spatial dimensionparallel to ours. It appears in mythology.', 16, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (485, 'Heatran', 'It dwells in volcanic caves. It digs in with itscross-shaped feet to crawl on ceilings and walls.', 17, 2, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (486, 'Regigigas', 'It is said to have made Pokémon that look likeitself from a special ice mountain, rocks, and magma.', 18, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (487, 'Giratina', 'This Pokémon is said to live in a world on thereverse side of ours, where common knowledge isdistorted and strange.', 5, 4, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (488, 'Cresselia', 'Shiny particles are released from its wings like aveil. It is said to represent the crescent moon.', 8, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (489, 'Phione', 'When the water warms, they inflate the flotation sacon their heads and drift languidly on the seain packs.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (490, 'Manaphy', 'It is born with a wondrous power that lets it bondwith any kind of Pokémon.', 16, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (491, 'Darkrai', 'It chases people and Pokémon from its territory bycausing them to experience deep, nightmarish slumbers.', 3, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (492, 'Shaymin', 'It can dissolve toxins in the air to instantlytransform ruined land into a lush field of flowers.', 14, NULL, 1, 2, 3, 4);
INSERT INTO Pokemon VALUES (493, 'Arceus', 'According to the legends of Sinnoh, this Pokémonemerged from an egg and shaped all there is inthis world.', 18, NULL, 1, 2, 3, 4);
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