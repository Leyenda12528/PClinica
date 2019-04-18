using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using ProyectoTrr.Datos;
using System.Windows.Forms;

namespace ProyectoTrr.Base
{
    public class Consultas
    {

        private SqlConnection con;
        private String sql;
        private SqlCommand comando = null;
        private SqlDataReader reader = null;

        public Consultas(){
            con = new SqlConnection(Conexion.cadena);
        }

        public void getUsers(ComboBox cBIdUser)
        {
            try
            {
                sql = "select id_user from usuarios";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())
                    cBIdUser.Items.Add(reader.GetValue(0));
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        public void getDatosUser(Usuario user)
        {
            try
            {
                sql = "select * from usuarios where id_user = @id";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@id", user.Id_user));
                con.Open();
                reader = comando1.ExecuteReader();
                if (reader.Read())
                {
                    user.Nombre = reader.GetValue(1).ToString();
                    user.Apellido = reader.GetValue(2).ToString();
                    user.Edad = Convert.ToInt32(reader.GetValue(3));
                    user.Telefono = reader.GetValue(4).ToString();
                    user.User = reader.GetValue(5).ToString();
                    user.Pass = reader.GetValue(6).ToString();
                    user.ID_especialidad = Convert.ToInt32(reader.GetValue(7));
                    user.ID_estdo = Convert.ToInt32(reader.GetValue(8));
                }                
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public void UpdateUser(Usuario user)
        {
            try
            {
                sql = "update usuarios set nombre = @n, apellido = @ap, edad = @ed, telefono = @tel,"
                    + " usuario = @us, pass = @pass, id_especial = @idesp, id_estado_user = @idest"
                    + " where id_user = @id";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@n", user.Nombre));
                comando1.Parameters.Add(new SqlParameter("@ap", user.Apellido));
                comando1.Parameters.Add(new SqlParameter("@ed", user.Edad));
                comando1.Parameters.Add(new SqlParameter("@tel", user.Telefono));
                comando1.Parameters.Add(new SqlParameter("@us", user.User));
                comando1.Parameters.Add(new SqlParameter("@pass", user.Pass));
                comando1.Parameters.Add(new SqlParameter("@idesp", user.ID_especialidad));
                comando1.Parameters.Add(new SqlParameter("@idest", user.ID_estdo));
                comando1.Parameters.Add(new SqlParameter("@id", user.Id_user));
                con.Open();
                comando1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Usuario Modificado");
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public void getEspecialidad(ComboBox cBEspel)
        {
            try
            {
                sql = "select Nombre_espec from especialidad";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())
                    cBEspel.Items.Add(reader.GetValue(0));
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public void getNewIdUser(Usuario user)
        {
            try
            {
                sql = "select count(*) from usuarios";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                if (reader.Read())
                    user.Id_user = Convert.ToInt32(reader.GetValue(0));
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public void AddUser(Usuario user)
        {
            try
            {
                sql = "insert into usuarios (id_user, nombre, apellido, edad, telefono, "
                    + "usuario, pass, id_especial, id_estado_user) "
                    + "values (@id, @n, @a, @ed, @tel, @us, @pass, @espel, @estado)";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@id", user.Id_user));
                comando1.Parameters.Add(new SqlParameter("@n", user.Nombre));
                comando1.Parameters.Add(new SqlParameter("@a", user.Apellido));
                comando1.Parameters.Add(new SqlParameter("@ed", user.Edad));
                comando1.Parameters.Add(new SqlParameter("@tel", user.Telefono));
                comando1.Parameters.Add(new SqlParameter("@us", user.User));
                comando1.Parameters.Add(new SqlParameter("@pass", user.Pass));
                comando1.Parameters.Add(new SqlParameter("@espel", user.ID_especialidad));
                comando1.Parameters.Add(new SqlParameter("@estado", user.ID_estdo));
                con.Open();
                comando1.ExecuteNonQuery();
                con.Close();                
                MessageBox.Show("Usuario Agregado!!");
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public bool UserExits(string v)
        {
            try
            {
                sql = "select  id_user from usuarios where usuario = @user";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@user", v));
                con.Open();
                reader = comando1.ExecuteReader();
                Boolean var = false;
                if (reader.Read())                                    
                    var = true;
                else var = false;
                con.Close();
                return var;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        public bool exist(string user, string pass, Usuario usuario)
        {
            try
            {
                sql = "select  id_user from usuarios where usuario = @user and pass = @pass ";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@user", user));
                comando1.Parameters.Add(new SqlParameter("@pass", pass));
                //MessageBox.Show("\nUs " + user + "\nPass " + pass);
                con.Open();
                reader = comando1.ExecuteReader();
                Boolean var = false;
                if (reader.Read())
                {
                    usuario.Id_user = Convert.ToInt32(reader.GetValue(0));
                    var = true;
                }
                else var = false;                
                con.Close();
                return var;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        internal void getDatosPac(Paciente pacu)
        {
            try
            {
                sql = "select * from paciente where id_pac = @id";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@id", pacu.ID_pac));
                con.Open();
                reader = comando1.ExecuteReader();
                if (reader.Read())
                {
                    pacu.Nombre = reader.GetValue(1).ToString();
                    pacu.Apellido = reader.GetValue(2).ToString();
                    String d = reader.GetValue(3).ToString();
                    if (d.Length > 0) pacu.Edad = Convert.ToInt32(reader.GetValue(3));
                    pacu.Tel = reader.GetValue(4).ToString();
                    pacu.Direccion = reader.GetValue(5).ToString();
                    pacu.Sangre = reader.GetValue(6).ToString();
                    pacu.NombreC = reader.GetValue(7).ToString();
                    pacu.TelC = reader.GetValue(8).ToString();
                    d = reader.GetValue(9).ToString();
                    if (d.Length > 0) pacu.ID_estado = Convert.ToInt32(reader.GetValue(9));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        internal void ModifyPaciente(Paciente pacu)
        {
            try
            {
                sql = "update paciente set nombre = @n, apellido = @ap, edad = @ed, telefono = @tel,"
                    + " direccion = @dir, tipoSangre = @san, Nombre_contacto = @nc, telefono_contacto = @telc,"
                    +" id_estado = @ides where id_pac = @idpac";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@n", pacu.Nombre));
                comando1.Parameters.Add(new SqlParameter("@ap", pacu.Apellido));
                comando1.Parameters.Add(new SqlParameter("@ed", pacu.Edad));
                comando1.Parameters.Add(new SqlParameter("@tel", pacu.Tel));
                comando1.Parameters.Add(new SqlParameter("@dir", pacu.Direccion));
                comando1.Parameters.Add(new SqlParameter("@san", pacu.Sangre));
                comando1.Parameters.Add(new SqlParameter("@nc", pacu.NombreC));
                comando1.Parameters.Add(new SqlParameter("@telc", pacu.TelC));
                comando1.Parameters.Add(new SqlParameter("@ides", pacu.ID_estado));
                comando1.Parameters.Add(new SqlParameter("@idpac", pacu.ID_pac));
                con.Open();
                comando1.ExecuteNonQuery();
                con.Close();                
                MessageBox.Show("Paciente Modificado");
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        internal void AddConsulta(Consulta consulC)
        {
            try
            {
                sql = "insert into consulta (id_consulta, id_paciente, id_doc, fechalleg, id_categoria,"
                    + "puntaje_obt, id_estado) values (@id, @idp, @idd, GETDATE(), @categ, @punt, @id_est)";
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@id", consulC.Id_consulta));
                comando1.Parameters.Add(new SqlParameter("@idp", consulC.Id_pac));
                comando1.Parameters.Add(new SqlParameter("@idd", consulC.Id_doc));
                comando1.Parameters.Add(new SqlParameter("@categ", consulC.Categoria));
                comando1.Parameters.Add(new SqlParameter("@punt", consulC.Puntaje));
                comando1.Parameters.Add(new SqlParameter("@id_est", consulC.Id_estado));                
                con.Open();
                comando1.ExecuteNonQuery();
                con.Close();
                addConsul_Sin(consulC);
                MessageBox.Show("Consulta Agregada");
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        private void addConsul_Sin(Consulta consulC)
        {
            try
            {
                sql = "insert into consulta_sintoma values (" + consulC.Id_consulta + ",@idsin)";
                foreach (int item in consulC.ListaSintomas)
                {
                    SqlCommand comando1 = new SqlCommand(sql, con);
                    comando1.Parameters.Add(new SqlParameter("@idsin", item));
                    con.Open();
                    comando1.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }
        }

        internal void getSintomas(CheckedListBox listSintomas, List<Sintomas> listaSin)
        {
            try
            {
                sql = "select * from sintoma";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())
                {
                    Sintomas sin = new Sintomas();
                    sin.Id_Sintoma = Convert.ToInt32(reader.GetValue(0));
                    sin.Sintoma = reader.GetValue(1).ToString();
                    sin.Puntaje = Convert.ToInt32(reader.GetValue(2));
                    sin.Status = 0;
                    listaSin.Add(sin);
                    listSintomas.Items.Add(reader.GetValue(1));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        internal void getDocs(ComboBox cBIdDoc)
        {
            try
            {
                sql = "select id_user from usuarios where id_especial <> 2 and id_estado_user = 0";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())
                    cBIdDoc.Items.Add(reader.GetValue(0));
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        internal void getPac(ComboBox cBIdPac, int i)
        {//todos los pacientes 
            try
            {
                sql = "select id_pac from paciente";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())
                    cBIdPac.Items.Add(reader.GetValue(0));
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        internal void getPac(ComboBox cBIdPac)
        {//todos los paciente Activos
            try
            {
                sql = "select id_pac from paciente where id_estado = 0";
                SqlCommand comando1 = new SqlCommand(sql, con);
                con.Open();
                reader = comando1.ExecuteReader();
                while (reader.Read())                
                    cBIdPac.Items.Add(reader.GetValue(0));                
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        internal int getIdNewConsult()
        {
            int Cn = 0;
            try
            {
                sql = "select count(*) from consulta";
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                reader = com.ExecuteReader();
                if (reader.Read())
                    Cn = Convert.ToInt32(reader.GetValue(0));
                con.Close();                               
                return Cn;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                throw;
            }            
        }

        public void AddPcDetalle(Paciente pac)
        {
            try
            {                
                sql = "insert into paciente (id_pac, nombre, apellido, edad, telefono, direccion, tipoSangre, Nombre_contacto, telefono_contacto, id_estado)"
                    +"values (@id, @Nom, @Ap, @Ed, @Tel, @Dir, @San, @NomC, @TelC, 0)";                
                
                SqlCommand comando1 = new SqlCommand(sql, con);
                comando1.Parameters.Add(new SqlParameter("@id", pac.ID_pac));
                comando1.Parameters.Add(new SqlParameter("@Nom", pac.Nombre));
                comando1.Parameters.Add(new SqlParameter("@Ap", pac.Apellido));
                comando1.Parameters.Add(new SqlParameter("@Ed", pac.Edad));
                comando1.Parameters.Add(new SqlParameter("@Tel", pac.Tel));
                comando1.Parameters.Add(new SqlParameter("@Dir", pac.Direccion));
                comando1.Parameters.Add(new SqlParameter("@San", pac.Sangre));
                comando1.Parameters.Add(new SqlParameter("@NomC", pac.NombreC));
                comando1.Parameters.Add(new SqlParameter("@TelC", pac.TelC));
                con.Open();
                comando1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nuevo Paciente Ingresado Exitosamente\nSu ID es " + pac.ID_pac);
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
                con.Close();
            }
        }

        public int LastIDPac()
        {
            try
            {
                int contador = 0;
                sql = "select count(*) from paciente";
                //porsi();
                con.Close();
                con.Open();
                comando = new SqlCommand(sql, con);
                reader = comando.ExecuteReader();
                if (reader.Read())
                    contador = Convert.ToInt32(reader.GetValue(0));
                con.Close();
                return contador;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("" + e);
                return -1;
            }
        }

        public void AddPcInmediato()
        {
            try
            {
                int contador = LastIDPac();
                //if (contador > 0) contador = contador + 1;
                sql = "insert into paciente (id_pac, id_estado)values (" + contador + ",0)";
                //porsi();
                con.Open();
                comando = new SqlCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("el ID del nuevo paciente es : " + contador);
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        public void getDatos(Usuario usuario)
        {
            try
            {
                sql = "SELECT  concat(usuarios.nombre,' ',usuarios.apellido), usuarios.id_especial,"
                        + " especialidad.Nombre_espec"
                        + " FROM  usuarios INNER JOIN"
                        + " especialidad ON usuarios.id_especial = especialidad.id"
                        + " WHERE id_user = @id ";
                //porsi();
                con.Open();
                comando = new SqlCommand(sql, con);
                comando.Parameters.Add(new SqlParameter("@id", usuario.Id_user));
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    usuario.Nombre = reader.GetValue(0).ToString();
                    usuario.ID_especialidad = Convert.ToInt32(reader.GetValue(1));
                    usuario.Especialidad = reader.GetValue(2).ToString();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e);
            }
        } 
    }
}
