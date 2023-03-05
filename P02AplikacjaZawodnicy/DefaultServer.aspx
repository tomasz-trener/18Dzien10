<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultServer.aspx.cs" Inherits="P02AplikacjaZawodnicy.DefaultServer" %>

  <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Imie i nazwisko
                      </th>
                      <th>
                        Kraj
                      </th>
                      <th>
                        Wzrost
                      </th>
                      <th  >
                        Data urodzenia
                      </th>
                    </thead>
                    <tbody>
                    
                    <% foreach (var z in Zawodnicy)
                        { %>    
                            <tr>
                                <td> <a href="SzczegolyZawodnika.aspx?id=<%= z.Id_zawodnika %>"> <%= z.ImieNazwisko %></a></td>
                                <td><%= z.Kraj %></td>
                                <td><%= z.Wzrost %></td>
                                <td><%= z.DataUrodzenia?.ToString("dd.MM.yyyy") %></td>
                            </tr>
                        
                <%      } %>

                    </tbody>
                  </table>