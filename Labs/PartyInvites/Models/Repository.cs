using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        //responses is a class field
        private static List<GuestResponse> responses = new List<GuestResponse>();
        //Responses is a class property
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response) //class method
        {
            responses.Add(response);
        }
    }
}