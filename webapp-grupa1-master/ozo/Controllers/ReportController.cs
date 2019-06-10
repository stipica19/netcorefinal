using ozo.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PdfRpt.ColumnsItemsTemplates;
using PdfRpt.Core.Contracts;
using PdfRpt.Core.Helper;
using PdfRpt.FluentInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ozo.ViewModels;

namespace ozo.Controllers
{
    public class ReportController : Controller
    {
        private readonly PI01Context ctx;

        public ReportController(PI01Context ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Oprema()
        {
            string naslov = "Popis opreme";
            var biljke = await ctx.Oprema
                .AsNoTracking()
                .Include(c => c.Status)
                .Include(d => d.ReferentniTipOpreme)
                .Include(e => e.LokacijaOpreme)

                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(biljke));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(0);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("OpremaId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(1);
                    column.Width(2);
                    column.HeaderCell("ID-Opreme");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<Oprema>(x => x.NabavnaCijena);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(3);
                    column.HeaderCell("Nabavna cijena", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Oprema>(x => x.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(3);
                    column.HeaderCell("Naziv", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<Oprema>(x => x.LokacijaOpreme.NazivLokacije);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(1);
                    column.HeaderCell("Lokacija", horizontalAlignment: HorizontalAlignment.Center);
                });


            });

            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }


        public async Task<IActionResult> Usluga()
        {
            string naslov = "POPIS USLUGA";
            var usluge = await ctx.Vw_Usluga

                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(usluge));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("UslugaId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("uslugaId");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewUsluga>(x => x.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Ime", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewUsluga>(x => x.Opis);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Opis", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewUsluga>(x => x.KategorijaPoslaNaziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(1);
                    column.HeaderCell("Kategorija posla", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewUsluga>(x => x.NazivTipaOpreme);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Oprema", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<UslugaViewModel>(x => x.NazivTipaZanimanja);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Zanimanje", horizontalAlignment: HorizontalAlignment.Center);
                });




            });

            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }



        public async Task<IActionResult> Osoba()
        {
            string naslov = "Popis Osoba";
            var biljke = await ctx.Vw_Osoba
                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(biljke));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("OsobaId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("ID-Osobe");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewOsoba>(x => x.Ime);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Ime", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewOsoba>(x => x.Prezime);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Prezime", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewOsoba>(x => x.God_rodjenja);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(1);
                    column.HeaderCell("Godina rodjenja", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewOsoba>(x => x.NazivCertifikata);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Certifikat", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewOsoba>(x => x.NazivZanimanja);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Zanimanje", horizontalAlignment: HorizontalAlignment.Center);
                });


            });



            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }


        public async Task<IActionResult> Najam()
        {
            string naslov = "Popis najmova";
            var biljke = await ctx.Vw_Najam
               
                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(biljke));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("NajamId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("ID");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.Opis);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Opis", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.NazivFirme);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Naziv firme", horizontalAlignment: HorizontalAlignment.Center);
                });


                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.DatumOd);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell(" Datum od", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.DatumDo);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Datum do", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.NazivOpreme);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Naziv opreme", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.VrstaNajma);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrsta najma", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<ViewNajam>(x => x.Kolicina);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Kolicina", horizontalAlignment: HorizontalAlignment.Center);
                });


            });



            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }




        public async Task<IActionResult> Servis()
        {
            string naslov = "Popis Servisa";
            var servis = await ctx.Servis
                .Include(c=>c.Oprema)
                .Include(c => c.Serviser)
                .Include(c => c.Osoba)
                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(servis));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("ServisId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("ID");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<Servis>(x => x.Oprema.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Oprema", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Servis>(x => x.Serviser.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Serviser", horizontalAlignment: HorizontalAlignment.Center);
                });


                columns.AddColumn(column =>
                {
                    column.PropertyName<Servis>(x => x.Cijena);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell(" Cijena", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Servis>(x => x.Osoba.Ime);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Osoba", horizontalAlignment: HorizontalAlignment.Center);
                });
                


            });



            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }



        public async Task<IActionResult> Natjecaj()
        {
            string naslov = "Popis Natjecaja";
            var servis = await ctx.Natjecaj
                .Include(c=>c.VrstaNatjecaja)
                .Include(c=>c.Pobiednik)
                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(servis));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("NatjecajId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("ID");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Naziv", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.Opis);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Opis", horizontalAlignment: HorizontalAlignment.Center);
                });


                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.Vrijednost);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell(" Vrijednost", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.VrijemeOd);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrijeme od", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.VrijemeDo);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrijeme do", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.VrstaNatjecaja.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrsta natjecaja", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<Natjecaj>(x => x.Pobiednik.Naziv);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Pobjednik", horizontalAlignment: HorizontalAlignment.Center);
                });




            });



            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }



        public async Task<IActionResult> Posao()
        {
            string naslov = "Popis Poslova";
            var servis = await ctx.Vw_Posao
                
                .AsNoTracking()


                .ToListAsync();
            PdfReport report = CreateReport(naslov);
            // byte[] content;

            #region Podnožje i zaglavlje

            report.PagesFooter(footer => { footer.DefaultFooter(DateTime.Now.ToString("dd.MM.yyyy.")); })
                .PagesHeader(header =>
                {
                    header.CacheHeader(cache: true); // It's a default setting to improve the performance.
                    header.DefaultHeader(defaultHeader =>
                    {
                        defaultHeader.RunDirection(PdfRunDirection.LeftToRight);
                        defaultHeader.Message(naslov);
                    });
                });

            #endregion

            #region Postavljanje izvora podataka i stupaca

            report.MainTableDataSource(dataSource => dataSource.StronglyTypedList(servis));

            report.MainTableColumns(columns =>
            {
                columns.AddColumn(column =>
                {
                    column.IsRowNumber(true);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Right);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("#", horizontalAlignment: HorizontalAlignment.Right);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName("PosaoId");
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("ID");
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.Opis);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Opis", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.Cijena);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(2);
                    column.Width(1);
                    column.HeaderCell("Cijena", horizontalAlignment: HorizontalAlignment.Center);
                });


                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.DodatniTrosak);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell(" Dodatni trosak", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.VrijemeOd);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrijeme od", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.VrijemeDo);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Vrijeme do", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.NazivZanimanja);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Naziv zanimanja", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.NazivOpreme);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Naziv opreme", horizontalAlignment: HorizontalAlignment.Center);
                });
                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.KategorijaId);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Kategorija ID", horizontalAlignment: HorizontalAlignment.Center);
                });

                columns.AddColumn(column =>
                {
                    column.PropertyName<PosaoViewModel>(x => x.NazivUsluge);
                    column.CellsHorizontalAlignment(HorizontalAlignment.Center);
                    column.IsVisible(true);
                    column.Order(3);
                    column.Width(2);
                    column.HeaderCell("Naziv usluge", horizontalAlignment: HorizontalAlignment.Center);
                });


            });



            #endregion

            byte[] pdf = report.GenerateAsByteArray();

            if (pdf != null)
            {
                Response.Headers.Add("content-disposition", "inline; filename=posao.pdf");
                return File(pdf, "application/pdf");
                //return File(pdf, "application/pdf", "biljke.pdf"); //Otvara save as dialog
            }
            else
                return NotFound();
        }

        #region Private methods

        private PdfReport CreateReport(string naslov)
        {
            var pdf = new PdfReport();

            pdf.DocumentPreferences(doc =>
                {
                    doc.Orientation(PageOrientation.Portrait);
                    doc.PageSize(PdfPageSize.A4);
                    doc.DocumentMetadata(new DocumentMetadata
                    {
                        Author = "GRUPA 001",
                        Application = "ozo",
                        Title = naslov
                    });
                    doc.Compression(new CompressionSettings
                    {
                        EnableCompression = true,
                        EnableFullCompression = true
                    });
                })
                .MainTableTemplate(template => { template.BasicTemplate(BasicTemplate.ProfessionalTemplate); })
                .MainTablePreferences(table =>
                {
                    table.ColumnsWidthsType(TableColumnWidthType.Relative);
                    //table.NumberOfDataRowsPerPage(20);
                    table.GroupsPreferences(new GroupsPreferences
                    {
                        GroupType = GroupType.HideGroupingColumns,
                        RepeatHeaderRowPerGroup = true,
                        ShowOneGroupPerPage = true,
                        SpacingBeforeAllGroupsSummary = 5f,
                        NewGroupAvailableSpacingThreshold = 150,
                        SpacingAfterAllGroupsSummary = 5f
                    });
                    table.SpacingAfter(4f);
                });

            return pdf;
        }
        #endregion
      
    }
   
}