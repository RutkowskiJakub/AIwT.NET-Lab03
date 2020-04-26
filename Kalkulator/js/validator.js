function sprawdzWartosc1()
{
    var formularz_obj=document.getElementById("wartosc1");
    var t_wartosc1 = formularz_obj.value;
    var blad = document.getElementById("wartosc1Error");

    if (t_wartosc1 === "")
    {
        blad.innerHTML = "Wprowadz liczbe";
        blad.classList.add("invalid-feedback");
        formularz_obj.classList.add("is-invalid");
        blad.classList.remove("valid-feedback");
        formularz_obj.classList.remove("is-valid");
        blad_danych=true;
        document.getElementById("wartosc1").value = "";
        document.getElementById("wynik").value = null;
    }
    else
    {
            blad.classList.remove("invalid-feedback");
            formularz_obj.classList.remove("is-invalid");
            blad.classList.add("valid-feedback");
            formularz_obj.classList.add("is-valid");
            blad.innerHTML = "";
            blad_danych=false;
    }
    return blad_danych
}

function sprawdzWartosc2()
{
    var formularz_obj=document.getElementById("wartosc2");
    var t_wartosc2 = formularz_obj.value;
    var blad = document.getElementById("wartosc2Error");

    if (t_wartosc2 === "")
    {
        blad.innerHTML = "Wprowadz liczbe";
        blad.classList.add("invalid-feedback");
        formularz_obj.classList.add("is-invalid");
        blad.classList.remove("valid-feedback");
        formularz_obj.classList.remove("is-valid");
        blad_danych=true;
        document.getElementById("wartosc2").value = "";
        document.getElementById("wynik").value = null;
    }
    else
    {
        blad.classList.remove("invalid-feedback");
        formularz_obj.classList.remove("is-invalid");
        blad.classList.add("valid-feedback");
        formularz_obj.classList.add("is-valid");
        blad.innerHTML = "";
        blad_danych=false;
    }
    return blad_danych
}

function sprawdzDzialanie()
{
    var formularz_obj=document.getElementById("dzialanie");
    var t_dzialanie = formularz_obj.value;
    var blad = document.getElementById("dzialanieError");


    if (t_dzialanie == 0)
    {
        blad.innerHTML = "Wybierz działanie";
        blad.classList.add("invalid-feedback");
        formularz_obj.classList.add("is-invalid");
        blad.classList.remove("valid-feedback");
        formularz_obj.classList.remove("is-valid");
        blad_danych=true;
        document.getElementById("wynik").value = null;
    }
    else
    {
        blad.classList.remove("invalid-feedback");
        formularz_obj.classList.remove("is-invalid");
        blad.classList.add("valid-feedback");
        formularz_obj.classList.add("is-valid");
        blad.innerHTML = "";
        blad_danych=false;
    }
    return blad_danych
}

function sprawdzWszystko()
{
    console.log("Weszlo w sprawdzanie wszystkiego");
    if (sprawdzWartosc1() == false && sprawdzWartosc2() == false && sprawdzDzialanie() == false)
    {
        var a = parseFloat(document.getElementById("wartosc1").value);
        var b = parseFloat(document.getElementById("wartosc2").value);
        var c = document.getElementById("dzialanie").value;
        var x=0;
        var dzieleniePrzezZero = 0;
        switch(c){
            case '1':
            x=a+b;
            break;
            case '2':
            x=a-b;
            break;
            case '3':
            x=a*b;
            break;
            case '4':
            if(b!=0)
            {
            x=a/b;
            }
            else
            {
            alert("Nie można dzielić przez 0!");   
            dzieleniePrzezZero = 1;
            }
            break;
        }
        
        console.log("a = " + a);
        console.log("b = " + b);
        console.log("c = " + c);
        console.log("x = " + x);

        if (dzieleniePrzezZero != 1)
        {
            document.getElementById("wynik").value = x;
        }
        else
        {
            document.getElementById("wynik").value = null;
        }
        

    } 
    else
    {
        console.log("Nie bangla");
        console.log("sprawdz wartość 1: " + sprawdzWartosc1());
        console.log("sprawdz wartość 2: " + sprawdzWartosc2());
        console.log("sprawdz działanie: " + sprawdzDzialanie());

    }
}
