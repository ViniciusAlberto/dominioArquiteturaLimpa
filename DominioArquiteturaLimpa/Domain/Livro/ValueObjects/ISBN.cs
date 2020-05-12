namespace DominioArquiteturaLimpa.Domain.ValueObjects
{
    using System;


    public readonly struct ISBN : IEquatable<ISBN>
    {
        public static string NormalizeIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }
        public static bool CheckIsbn(string isbn) // formula to check ISBN's validity
        {
            if (isbn == null)
                return false;

            isbn = NormalizeIsbn(isbn);
            if (isbn.Length != 10)
                return false;

            int result;
            for (int i = 0; i < 9; i++)
                if (!int.TryParse(isbn[i].ToString(), out result))
                    return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (i + 1) * int.Parse(isbn[i].ToString());

            int remainder = sum % 11;
            if (remainder == 10)
                return isbn[9] == 'X';
            else
                return isbn[9] == (char)('0' + remainder);
        }

    }
}