using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
	[OperationContract]
	string Registrate(User new_user);
	[OperationContract]
	string SingIn(string login, string password);

	// TODO: Добавьте здесь операции служб
}

[DataContract]
public class User
{
	[DataMember]
	public int id { get; set; }
	[DataMember]
	public string Login { get; set; }
	[DataMember]
	public string Password { get; set; }
	[DataMember]
	public string Name { get; set; }

}