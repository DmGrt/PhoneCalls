namespace PhoneCalls.Domain.Classes
{
    public class Block
    {
        public Block(User currentUser, string numbToBlock)
        {
            this.User = currentUser;
            this.numbToBlock = numbToBlock;
        }

        private User User;
        private string numbToBlock;


        public void BlockUser()
        {
            if (!IsBlocked())
                User.AddToBlockList(numbToBlock);
        }

        public void UnblockUser()
        {
            if (IsBlocked())
                User.RemoveFromBlockList(numbToBlock);
        }

        public bool IsBlocked()
        {
            var ch = User.BlockedNumbers.Contains(numbToBlock);
            return ch;
        }
    }
}
