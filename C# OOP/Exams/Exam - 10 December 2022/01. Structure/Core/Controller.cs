namespace ChristmasPastryShop.Core
{
    using System;
    using System.Text;
    using System.Linq;

    using Contracts;
    using Models.Booths;
    using Models.Booths.Contracts;
    using Models.Cocktails;
    using Models.Cocktails.Contracts;
    using Models.Delicacies;
    using Models.Delicacies.Contracts;
    using Repositories;
    using Repositories.Contracts;

    public class Controller : IController
    {
        private IRepository<IBooth> booths;

        public Controller()
        {
            this.booths = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            var boothId = this.booths.Models.Count + 1;
            var booth = new Booth(boothId, capacity);

            this.booths.AddModel(booth);

            return $"Added booth number {boothId} with capacity {capacity} in the pastry shop!";
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {

            IDelicacy delicacy;

            if (delicacyTypeName == nameof(Gingerbread))
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else if (delicacyTypeName == nameof(Stolen))
            {
                delicacy = new Stolen(delicacyName);
            }
            else
            {
                return $"Delicacy type {delicacyTypeName} is not supported in our application!";
            }

            var booth = this.booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            var delicacyToSearch = booth.DelicacyMenu.Models.FirstOrDefault(x => x.Name == delicacyName);

            if (delicacyToSearch != null)
            {
                return $"{delicacyName} is already added in the pastry shop!";
            }

            booth.DelicacyMenu.AddModel(delicacy);

            return $"{delicacyTypeName} {delicacyName} added to the pastry shop!";
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != nameof(Hibernation) && cocktailTypeName != nameof(MulledWine))
            {
                return $"Cocktail type {cocktailTypeName} is not supported in our application!";
            }

            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return $"{size} is not recognized as valid cocktail size!";
            }

            ICocktail cocktail = null;

            if (cocktailTypeName == nameof(Hibernation))
            {
                cocktail = new Hibernation(cocktailName, size);
            }
            else if (cocktailTypeName == nameof(MulledWine))
            {
                cocktail = new MulledWine(cocktailName, size);
            }

            var booth = this.booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            var searchedCocktail = booth.CocktailMenu.Models.FirstOrDefault(x => x.Name == cocktailName && x.Size == size);

            if (searchedCocktail != null)
            {
                return $"{size} {cocktailName} is already added in the pastry shop!";
            }

            booth.CocktailMenu.AddModel(cocktail);

            return $"{size} {cocktailName} {cocktailTypeName} added to the pastry shop!";
        }

        public string ReserveBooth(int countOfPeople)
        {
            var orderedBooths = this.booths.Models.Where(x => !x.IsReserved)
                .Where(x => x.Capacity >= countOfPeople)
                .OrderBy(x => x.Capacity)
                .OrderByDescending(x => x.BoothId)
                .ToList();

            if (orderedBooths.Count == 0)
            {
                return $"No available booth for {countOfPeople} people!";
            }

            var firstAvailableBooth = orderedBooths.First();

            firstAvailableBooth.ChangeStatus();

            return $"Booth {firstAvailableBooth.BoothId} has been reserved for {countOfPeople} people!";
        }

        public string TryOrder(int boothId, string order)
        {
            var orderAsAnArray = order.Split("/").ToArray();

            var itemTypeName = orderAsAnArray[0];
            var itemName = orderAsAnArray[1];
            var orderedPiecesCount = int.Parse(orderAsAnArray[2]);
            var size = String.Empty;

            if (itemTypeName != nameof(Hibernation)
                && itemTypeName != nameof(MulledWine)
                && itemTypeName != nameof(Gingerbread)
                && itemTypeName != nameof(Stolen))
            {
                return $"{itemTypeName} is not recognized type!";
            }

            var booth = this.booths.Models.FirstOrDefault(x => x.BoothId == boothId);

            if (itemTypeName == nameof(MulledWine) || itemTypeName == nameof(Hibernation))
            {
                var searchedItem = booth.CocktailMenu.Models.FirstOrDefault(x => x.Name == itemName);

                if (searchedItem == null)
                {
                    return $"There is no {itemTypeName} {itemName} available!";
                }

                size = orderAsAnArray[3];

                var item = booth.CocktailMenu.Models.FirstOrDefault(x => x.Name == itemName && x.Size == size);

                if (item == null)
                {
                    return $"There is no {size} {itemName} available!";
                }

                booth.UpdateCurrentBill(item.Price * orderedPiecesCount);
                return $"Booth {boothId} ordered {orderedPiecesCount} {itemName}!";
            }

            var searchedDelicacy = booth.DelicacyMenu.Models.FirstOrDefault(x => x.Name == itemName);

            if (searchedDelicacy == null)
            {
                return $"There is no {itemTypeName} {itemName} available!";
            }

            booth.UpdateCurrentBill(searchedDelicacy.Price * orderedPiecesCount);
            return $"Booth {boothId} ordered {orderedPiecesCount} {itemName}!";
        }

        public string LeaveBooth(int boothId)
        {
            var booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);

            var currentBill = booth.CurrentBill;

            booth.Charge();
            booth.ChangeStatus();

            var sb = new StringBuilder();

            sb.AppendLine($"Bill {currentBill:f2} lv")
                .AppendLine($"Booth {boothId} is now available!");

            return sb.ToString().TrimEnd();
        }

        public string BoothReport(int boothId)
        {
            var booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);

            return booth.ToString().TrimEnd();
        }
    }
}
