﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using MPEventFramework;
using static CitizenFX.Core.Native.API;

namespace CopsAndRobbers
{
    public class Main : BaseScript
    {
        Base core = new Base();

        public Main()
        {
            EventHandlers["onClientResourceStart"] += new Action<string>(OnClientResourceStart);
            Debug.WriteLine("MAIN SUBSCRIBING TO EVENTS");

            core.OnPlayerSpawned += OnPlayerSpawned;
            core.OnPlayerStartedWalking += OnPlayerStartedWalking;
            core.OnPlayerStoppedWalking += OnPlayerStoppedWalking;
            core.OnPlayerStartedRunning += OnPlayerStartedRunning;
            core.OnPlayerStoppedRunning += OnPlayerStoppedRunning;
            core.OnPlayerStartedSprinting += OnPlayerStartedSprinting;
            core.OnPlayerStoppedSprinting += OnPlayerStoppedSprinting;
            core.OnPlayerStartedJumping += OnPlayerStartedJumping;
            core.OnPlayerStoppedJumping += OnPlayerStoppedJumping;
            core.OnPlayerCuffed += OnPlayerCuffed;
            core.OnPlayerUnCuffed += OnPlayerUnCuffed;
            core.OnPlayerStartedToGetUp += OnPlayerStartedToGetUp;
            core.OnPlayerStoppedToGetUp += OnPlayerStoppedToGetUp;
            core.OnPlayerStartedToAimFromCover += OnPlayerStartedToAimFromCover;
            core.OnPlayerStoppedToAimFromCover += OnPlayerStoppedToAimFromCover;
            core.OnPlayerStartedGettingJacked += OnPlayerStartedGettingJacked;
            core.OnPlayerStoppedGettingJacked += OnPlayerStoppedGettingJacked;
            core.OnPlayerStartedJacking += OnPlayerStartedJacking;
            core.OnPlayerStoppedJacking += OnPlayerStoppedJacking;
            core.OnPlayerStartedGettingStunned += OnPlayerStartedGettingStunned;
            core.OnPlayerStoppedGettingStunned += OnPlayerStoppedGettingStunned;
            core.OnPlayerStartedClimbing += OnPlayerStartedClimbing;
            core.OnPlayerStoppedClimbing += OnPlayerStoppedClimbing;
            core.OnPlayerDied += OnPlayerDied;
            core.OnPlayerRevived += OnPlayerRevived;
            core.OnPlayerStartedDiving += OnPlayerStartedDiving;
            core.OnPlayerStoppedDiving += OnPlayerStoppedDiving;
            core.OnPlayerStartedDriveBy += OnPlayerStartedDriveBy;
            core.OnPlayerStoppedDriveBy += OnPlayerStoppedDriveBy;
            core.OnPlayerStartedFalling += OnPlayerStartedFalling;
            core.OnPlayerStoppedFalling += OnPlayerStoppedFalling;
            core.OnPlayerStartedOnFoot += OnPlayerStartedOnFoot;
            core.OnPlayerStoppedOnFoot += OnPlayerStoppedOnFoot;
            core.OnPlayerEnteredMeleeCombat += OnPlayerEnteredMeleeCombat;
            core.OnPlayerLeftMeleeCombat += OnPlayerLeftMeleeCombat;
            core.OnPlayerEnteredCover += OnPlayerEnteredCover;
            core.OnPlayerLeftCover += OnPlayerLeftCover;
            core.OnPlayerEnteredParachuteFreefall += OnPlayerEnteredParachuteFreefall;
            core.OnPlayerLeftParachuteFreefall += OnPlayerLeftParachuteFreefall;
            core.OnPlayerStartedReloading += OnPlayerStartedReloading;
            core.OnPlayerStoppedReloading += OnPlayerStoppedReloading;
            core.OnPlayerStartedShooting += OnPlayerStartedShooting;
            core.OnPlayerStoppedShooting += OnPlayerStoppedShooting;
            core.OnPlayerStartedSwimming += OnPlayerStartedSwimming;
            core.OnPlayerStoppedSwimming += OnPlayerStoppedSwimming;
            core.OnPlayerStartedSwimmingUnderwater += OnPlayerStartedSwimmingUnderwater;
            core.OnPlayerStoppedSwimmingUnderwater += OnPlayerStoppedSwimmingUnderwater;
            core.OnPlayerStartedStealthKill += OnPlayerStartedStealthKill;
            core.OnPlayerStoppedStealthKill += OnPlayerStoppedStealthKill;
            core.OnPlayerStartedVaulting += OnPlayerStartedVaulting;
            core.OnPlayerStoppedVaulting += OnPlayerStoppedVaulting;
            core.OnPlayerStartedWearingHelmet += OnPlayerStartedWearingHelmet;
            core.OnPlayerStoppedWearingHelmet += OnPlayerStoppedWearingHelmet;
            core.OnPlayerEnteredMainMenu += OnPlayerEnteredMainMenu;
            core.OnPlayerLeftMainMenu += OnPlayerLeftMainMenu;
            core.OnPlayerReadyToShoot += OnPlayerReadyToShoot;
            core.OnPlayerNotReadyToShoot += OnPlayerNotReadyToShoot;
            core.OnPlayerStartedAiming += OnPlayerStartedAiming;
            core.OnPlayerStoppedAiming += OnPlayerStoppedAiming;
            core.OnPlayerHealthGain += OnPlayerHealthGain;
            core.OnPlayerHealthLoss += OnPlayerHealthLoss;
            core.OnPlayerArmourGain += OnPlayerArmourGain;
            core.OnPlayerArmourLoss += OnPlayerArmourLoss;

            core.OnPlayerTryingToEnterVehicle += OnPlayerTryingToEnterVehicle;
            core.OnPlayerEnteredVehicle += OnPlayerEnteredVehicle;
            core.OnPlayerLeaveVehicle += OnPlayerLeaveVehicle;
            core.OnPlayerSeatChange += OnPlayerSeatChange;
            core.OnPlayerSpawnIntoVehicle += OnPlayerSpawnIntoVehicle;
            core.OnPlayerEnteredBoat += OnPlayerEnteredBoat;
            core.OnPlayerLeftBoat += OnPlayerLeftBoat;
            core.OnPlayerEnteredHeli += OnPlayerEnteredHeli;
            core.OnPlayerLeftHeli += OnPlayerLeftHeli;
            core.OnPlayerEnteredPlane += OnPlayerEnteredPlane;
            core.OnPlayerLeftPlane += OnPlayerLeftPlane;
            core.OnPlayerEnteredPoliceVehicle += OnPlayerEnteredPoliceVehicle;
            core.OnPlayerLeftPoliceVehicle += OnPlayerLeftPoliceVehicle;
            core.OnPlayerEnteredSub += OnPlayerEnteredSub;
            core.OnPlayerLeftSub += OnPlayerLeftSub;
            core.OnPlayerEnteredTaxi += OnPlayerEnteredTaxi;
            core.OnPlayerLeftTaxi += OnPlayerLeftTaxi;
            core.OnPlayerEnteredTrain += OnPlayerEnteredTrain;
            core.OnPlayerLeftTrain += OnPlayerLeftTrain;
            core.OnPlayerEnteredFlyingVehicle += OnPlayerEnteredFlyingVehicle;
            core.OnPlayerLeftFlyingVehicle += OnPlayerLeftFlyingVehicle;
            core.OnPlayerStartedOnBike += OnPlayerStartedOnBike;
            core.OnPlayerStoppedOnBike += OnPlayerStoppedOnBike;
            core.OnPlayerStartedOnVehicle += OnPlayerStartedOnVehicle;
            core.OnPlayerStoppedOnVehicle += OnPlayerStoppedOnVehicle;
            core.OnPlayerStartedJumpingOutOfVehicle += OnPlayerStartedJumpingOutOfVehicle;
            core.OnPlayerStoppedJumpingOutOfVehicle += OnPlayerStoppedJumpingOutOfVehicle;
            core.OnPlayerStartedMovingVehicle += OnPlayerStartedMovingVehicle;
            core.OnPlayerStoppedVehicle += OnPlayerStoppedVehicle;
            core.OnPlayerStartedBurnouting += OnPlayerStartedBurnouting;
            core.OnPlayerStoppedBurnouting += OnPlayerStoppedBurnouting;
            core.OnVehicleHealthGain += OnVehicleHealthGain;
            core.OnVehicleHealthLoss += OnVehicleHealthLoss;
            core.OnVehicleCrash += OnVehicleCrash;

            Debug.WriteLine("MAIN SUBSCRIBED TO EVENTS");
            // TODO testida nii palju evente kui saab.
        }

        public void OnPlayerSpawned()
        {
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
        }

        public void OnPlayerTryingToEnterVehicle(int vehicleHandle, int vehicleSeat)
        {
            Debug.WriteLine("CNR: OnTryingToEnterVehicle");
        }

        public void OnPlayerEnteredVehicle(int vehicleHandle, int vehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerEnteredVehicle");
        }
        
        public void OnPlayerLeaveVehicle(int vehicleHandle, int vehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerLeaveVehicle");
        }

        public void OnPlayerSeatChange(int vehicleHandle, int newVehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerSeatChange");
        }

        public void OnPlayerSpawnIntoVehicle(int vehicleHandle)
        {
            Debug.WriteLine("CNR: OnPlayerSpawnIntoVehicle");
        }

        public void OnPlayerStartedWalking()
        {
            Debug.WriteLine("CNR: OnPlayerStartedWalking");
        }

        public void OnPlayerStoppedWalking()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedWalking");
        }

        public void OnPlayerStartedRunning()
        {
            Debug.WriteLine("CNR: OnPlayerStartedRunning");
        }

        public void OnPlayerStoppedRunning()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedRunning");
        }

        public void OnPlayerStartedSprinting()
        {
            Debug.WriteLine("CNR: OnPlayerStartedSprinting");
        }

        public void OnPlayerStoppedSprinting()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedSprinting");
        }

        public void OnPlayerStartedJumping()
        {
            Debug.WriteLine("CNR: OnPlayerStartedJumping");
        }

        public void OnPlayerStoppedJumping()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedJumping");
        }

        public void OnPlayerCuffed()
        {
            Debug.WriteLine("CNR: OnPlayerCuffed");
        }

        public void OnPlayerUnCuffed()
        {
            Debug.WriteLine("CNR: OnPlayerUnCuffed");
        }

        public void OnPlayerStartedToGetUp()
        {
            Debug.WriteLine("CNR: OnPlayerStartedToGetUp");
        }

        public void OnPlayerStoppedToGetUp()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedToGetUp");
        }

        public void OnPlayerStartedToAimFromCover()
        {
            Debug.WriteLine("CNR: OnPlayerStartedToAimFromCover");
        }

        public void OnPlayerStoppedToAimFromCover()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedToAimFromCover");
        }

        public void OnPlayerStartedGettingJacked()
        {
            Debug.WriteLine("CNR: OnPlayerStartedGettingJacked");
        }

        public void OnPlayerStoppedGettingJacked()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedGettingJacked");
        }

        public void OnPlayerStartedJacking()
        {
            Debug.WriteLine("CNR: OnPlayerStartedJacking");
        }

        public void OnPlayerStoppedJacking()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedJacking");
        }

        public void OnPlayerStartedGettingStunned()
        {
            Debug.WriteLine("CNR: OnPlayerStartedGettingStunned");
        }

        public void OnPlayerStoppedGettingStunned()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedGettingStunned");
        }

        public void OnPlayerStartedClimbing()
        {
            Debug.WriteLine("CNR: OnPlayerStartedClimbing");
        }

        public void OnPlayerStoppedClimbing()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedClimbing");
        }

        public void OnPlayerDied()
        {
            Debug.WriteLine("CNR: OnPlayerDied");
        }

        public void OnPlayerRevived()
        {
            Debug.WriteLine("CNR: OnPlayerRevived");
        }

        public void OnPlayerStartedDiving()
        {
            Debug.WriteLine("CNR: OnPlayerStartedDiving");
        }

        public void OnPlayerStoppedDiving()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedDiving");
        }

        public void OnPlayerStartedDriveBy()
        {
            Debug.WriteLine("CNR: OnPlayerStartedDriveBy");
        }

        public void OnPlayerStoppedDriveBy()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedDriveBy");
        }

        public void OnPlayerStartedFalling()
        {
            Debug.WriteLine("CNR: OnPlayerStartedFalling");
        }

        public void OnPlayerStoppedFalling()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedFalling");
        }

        public void OnPlayerStartedOnFoot()
        {
            Debug.WriteLine("CNR: OnPlayerStartedOnFoot");
        }

        public void OnPlayerStoppedOnFoot()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedOnFoot");
        }

        public void OnPlayerEnteredMeleeCombat()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredMeleeCombat");
        }

        public void OnPlayerLeftMeleeCombat()
        {
            Debug.WriteLine("CNR: OnPlayerLeftMeleeCombat");
        }

        public void OnPlayerEnteredCover()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredCover");
        }

        public void OnPlayerLeftCover()
        {
            Debug.WriteLine("CNR: OnPlayerLeftCover");
        }

        public void OnPlayerEnteredParachuteFreefall()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredParachuteFreefall");
        }

        public void OnPlayerLeftParachuteFreefall()
        {
            Debug.WriteLine("CNR: OnPlayerLeftParachuteFreefall");
        }

        public void OnPlayerStartedReloading()
        {
            Debug.WriteLine("CNR: OnPlayerStartedReloading");
        }

        public void OnPlayerStoppedReloading()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedReloading");
        }

        public void OnPlayerStartedShooting()
        {
            Debug.WriteLine("CNR: OnPlayerStartedShooting");
        }

        public void OnPlayerStoppedShooting()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedShooting");
        }

        public void OnPlayerStartedSwimming()
        {
            Debug.WriteLine("CNR: OnPlayerStartedSwimming");
        }

        public void OnPlayerStoppedSwimming()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedSwimming");
        }

        public void OnPlayerStartedSwimmingUnderwater()
        {
            Debug.WriteLine("CNR: OnPlayerStartedSwimmingUnderwater");
        }

        public void OnPlayerStoppedSwimmingUnderwater()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedSwimmingUnderwater");
        }

        public void OnPlayerStartedStealthKill()
        {
            Debug.WriteLine("CNR: OnPlayerStartedStealthKill");
        }

        public void OnPlayerStoppedStealthKill()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedStealthKill");
        }

        public void OnPlayerStartedVaulting()
        {
            Debug.WriteLine("CNR: OnPlayerStartedVaulting");
        }

        public void OnPlayerStoppedVaulting()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedVaulting");
        }

        public void OnPlayerStartedWearingHelmet()
        {
            Debug.WriteLine("CNR: OnPlayerStartedWearingHelmet");
        }

        public void OnPlayerStoppedWearingHelmet()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedWearingHelmet");
        }

        public void OnPlayerEnteredMainMenu()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredMainMenu");
        }

        public void OnPlayerLeftMainMenu()
        {
            Debug.WriteLine("CNR: OnPlayerLeftMainMenu");
        }

        public void OnPlayerReadyToShoot()
        {
            Debug.WriteLine("CNR: OnPlayerReadyToShoot");
        }

        public void OnPlayerNotReadyToShoot()
        {
            Debug.WriteLine("CNR: OnPlayerNotReadyToShoot");
        }

        public void OnPlayerStartedAiming()
        {
            Debug.WriteLine("CNR: OnPlayerStartedAiming");
        }

        public void OnPlayerStoppedAiming()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedAiming");
        }

        public void OnPlayerHealthGain()
        {
            Debug.WriteLine("CNR: OnPlayerHealthGain");
        }

        public void OnPlayerHealthLoss()
        {
            Debug.WriteLine("CNR: OnPlayerHealthLoss");
        }

        public void OnPlayerArmourGain()
        {
            Debug.WriteLine("CNR: OnPlayerArmourGain");
        }

        public void OnPlayerArmourLoss()
        {
            Debug.WriteLine("CNR: OnPlayerArmourLoss");
        }

        public void OnPlayerEnteredBoat()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredBoat");
        }

        public void OnPlayerLeftBoat()
        {
            Debug.WriteLine("CNR: OnPlayerLeftBoat");
        }

        public void OnPlayerEnteredHeli()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredHeli");
        }

        public void OnPlayerLeftHeli()
        {
            Debug.WriteLine("CNR: OnPlayerLeftHeli");
        }

        public void OnPlayerEnteredPlane()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredPlane");
        }

        public void OnPlayerLeftPlane()
        {
            Debug.WriteLine("CNR: OnPlayerLeftPlane");
        }

        public void OnPlayerEnteredPoliceVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredPoliceVehicle");
        }

        public void OnPlayerLeftPoliceVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerLeftPoliceVehicle");
        }

        public void OnPlayerEnteredSub()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredSub");
        }

        public void OnPlayerLeftSub()
        {
            Debug.WriteLine("CNR: OnPlayerLeftSub");
        }

        public void OnPlayerEnteredTaxi()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredTaxi");
        }

        public void OnPlayerLeftTaxi()
        {
            Debug.WriteLine("CNR: OnPlayerLeftTaxi");
        }

        public void OnPlayerEnteredTrain()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredTrain");
        }

        public void OnPlayerLeftTrain()
        {
            Debug.WriteLine("CNR: OnPlayerLeftTrain");
        }

        public void OnPlayerEnteredFlyingVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerEnteredFlyingVehicle");
        }

        public void OnPlayerLeftFlyingVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerLeftFlyingVehicle");
        }

        public void OnPlayerStartedOnBike()
        {
            Debug.WriteLine("CNR: OnPlayerStartedOnBike");
        }

        public void OnPlayerStoppedOnBike()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedOnBike");
        }

        public void OnPlayerStartedOnVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStartedOnVehicle");
        }

        public void OnPlayerStoppedOnVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedOnVehicle");
        }

        public void OnPlayerStartedJumpingOutOfVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStartedJumpingOutOfVehicle");
        }

        public void OnPlayerStoppedJumpingOutOfVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedJumpingOutOfVehicle");
        }

        public void OnPlayerStartedMovingVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStartedMovingVehicle");
        }

        public void OnPlayerStoppedVehicle()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedVehicle");
        }

        public void OnPlayerStartedBurnouting()
        {
            Debug.WriteLine("CNR: OnPlayerStartedBurnouting");
        }

        public void OnPlayerStoppedBurnouting()
        {
            Debug.WriteLine("CNR: OnPlayerStoppedBurnouting");
        }

        public void OnVehicleHealthGain(int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Debug.WriteLine("CNR: OnVehicleHealthGain");
        }

        public void OnVehicleHealthLoss(int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Debug.WriteLine("CNR: OnVehicleHealthLoss");
        }

        public void OnVehicleCrash()
        {
            Debug.WriteLine("CNR: OnVehicleCrash");
        }

        [Tick]
        async Task OnTickMain()
        {
            core.Process();
        }

        bool helmState = false;

        // Some commands made for testing.

        private void OnClientResourceStart(string resourceName)
        {
            RegisterCommand("cuffs", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                Debug.WriteLine("cuffs1");
                if (IsPedCuffed(Base.PedHandle))
                {
                    Debug.WriteLine("cuffs2");
                    SetEnableHandcuffs(Base.PedHandle, false);
                }
                else
                {
                    Debug.WriteLine("cuffs3");
                    SetEnableHandcuffs(Base.PedHandle, true);
                }
            }), false);

            RegisterCommand("weapon", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int weapon = 0;

                if (Int32.TryParse(args[0].ToString(), out weapon))
                {
                    Debug.WriteLine("weapon " + weapon + " MPEventFramework.Weapon.weaponNames.Count:" + MPEventFramework.Weapon.weaponNames.Count);

                    if (weapon < MPEventFramework.Weapon.weaponNames.Count)
                    {
                        Debug.WriteLine("giving");
                        GiveWeaponToPed(Base.PedHandle, (uint)GetHashKey(MPEventFramework.Weapon.weaponNames[weapon]), 1000, false, true);
                    }
                }
            }), false);

            RegisterCommand("weaponstr", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                string weapon = args[0].ToString();

                Debug.WriteLine("giving");
                uint wep = (uint)GetHashKey(weapon);
                GiveWeaponToPed(Base.PedHandle, wep, 1, false, true);
                SetPedWeaponTintIndex(Base.PedHandle, wep, 1);
                SetPedInfiniteAmmo(Base.PedHandle, true, wep);
            }), false);

            RegisterCommand("hp", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int hp = 0;

                Debug.WriteLine("hp");
                if (Int32.TryParse(args[0].ToString(), out hp))
                {
                    Debug.WriteLine("hp:"+hp);
                    SetEntityHealth(Base.PedHandle, hp);
                }
            }), false);

            RegisterCommand("armour", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int arm = 0;

                Debug.WriteLine("arm");
                if (Int32.TryParse(args[0].ToString(), out arm))
                {
                    Debug.WriteLine("arm:" + arm);
                    SetPedArmour(Base.PedHandle, arm);
                }
            }), false);

            RegisterCommand("helm", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                helmState = !helmState;
                Debug.WriteLine("helmState:" + helmState);
                SetPedConfigFlag(Base.PedHandle, 35, helmState);
                GivePedHelmet(Base.PedHandle, false, helmState ? 1 : 0, 4096);
            }), false);

            RegisterCommand("para", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                SetPedGadget(Base.PedHandle, (uint)GetHashKey(("GADGET_PARACHUTE")), true);
            }), false);
        }
    }
}
