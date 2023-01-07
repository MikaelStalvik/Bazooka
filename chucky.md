
# Tips & trix i Bazooka för Salva mea:

- Kör i Windowed , high för "enklaste" läge
- Slå av greyscale via Post processing > Apply greyscale
- -Slå av overlayen (hjälper mkt!) via Post processing > PP Overlay

## "Små" texter kontrolleras från
 - re:re_scroll_index (text index)
 - re:re_scroll_offset_x (xoffset på text)
 - re:re_scroll_offset_y (yoffset på text)
 - re:re_char_count (antal tecken att visa)

## "Stora" texter kontrolleras från
 - re:re_scroll_index2 (text index)
 - re:re_scroll_offset2_x (xoffset på text)
 - re:re_scroll_offset2_y (yoffset på text)
 - re:re_char_count2 (antal tecken att visa)
 - re:re_logo_alpha2 (alpha, 1 = solid, 0 = transparent)
  
## Kamera
Inga special kameror eller splines används ännu.
Tänk på att om man flyttar en kamera kan ev. rök och partiklar behöva justeras.
### Variablar
 - camera:cam.x (xpos)
 - camera:cam.y (ypos)
 - camera:cam.z (zpos)
 - camera:cam.yaw (yaw)
 - camera:cam.pitch (pitch)
 
Det är en dålig ide att försöka pilla manuellt på dessa värden då de relaterar till aktuell scen.
Gör istället såhär:
1. Klicka på Main window > Sync and design
2. Tryck på C eller klicka i Main window > Capture mouse
3. Flytta som ett FPS spel med musen, WASD och ZX (evevation)
4. När en bra position hittats visas kamerans positioner nästan längst ner i Main window.
   Skriv antingen in dem i Bazooka därifrån ELLER, tryck på Backspace för att få dem dumpade i konsollfönstret.
   De visas nedanför "FOR SPLINE DATA" i ovan ordning.

För att "starta om" i en scen, klicka i "Sync Rocket var" och sedan på Sync and design igen.

Om kameran går för fort, sänk känsligheten från "Main window > Camera speed".

## Byte av scener
Aktuell scen styrs av mesh:scene1_mesh.
Följande scener finns:
- 0: Arms
- 1: Building01
- 2: Building02
- 3: Building03
- 4: Sfären med text
- 5: Courtyard
- 6: Torus tunnel
- 7: Credits
- 8: Tom
- 9: Greets

Meshens position styrs oftast av :
- mesh:mesh2_trans_x
- mesh:mesh2_trans_y
- mesh:mesh2_trans_z
- mesh:mesh2_rot_x
- mesh:mesh2_rot_y
- mesh:mesh2_rot_z
- mesh:mesh2_scale

Undvik att ändra på dessa, det är oftast bättre att ändra på kameran. :)
Greetz & credits är undantagna, dom är mer komplexa så dom går inte att modda lika enkelt.

## Längd:
Scener BÖR hålla längd i multipel av en bar (3.75s), där en bar är 64 rows.
En scen kan såklar vara 32 rows med, dvs 1/2 bar.
Bars visas som lila linjer i Bazooka. Det är optimalt att hålla åtminstonne jämna 8 eller 16 steg för synkar så en "kick drum" kommer var 8:e row (typ).

## Rendering loop
1. Shadow
2. G-buffer
3. Ljus
4. Marcher
5. SSR
6. Particles
7. DOF
8. PP's
9. Screen

## AO/Lightmap/Fog/Shadows/SSR:

### AO/SSAO
AO kan stras på två sätt, genererad eller baked.
För att använda genererad AO, SSAO, sätt postprocess:apply_ssao till 1 och postprocess:apply_baked_ssao till 0.
För att använda baked AO, sätt postprocess:apply_ssao till 0 och postprocess:apply_baked_ssao till 1.
Baked AO läggs på i g-buffer passet (innan ljus läggs på), SSAO läggs på efter g-buffer passet i ljuspasset.
Baked AO kan behöva en ljusare tonemap då ao appliceras direkt på albedo/diffuse.
Se även lightmap.

### Lightmap
Lightmap fungerar som baked AO och läggs på under g-buffer passet.
För att använda lightmaps, sätt postprocess:use_lightmap till 1.
Lightmap går att komibnera med beräknad ssao men inte med baked ao.

### Fog
Fog slås på via postprocess:use_fog till 1 och sedan postprocess:fog_type till:
- 0: Linear
- 1: Exponential
- 2: Exponential quared
- 3: Exponential gradient
- 4: Exponential with noise
Om fog är aktiv, justera densitet med postprocess:fog_density

### Shadows
För att slå på genererade shadows, sätt postprocess:use_shadows till 1.
Shadows beräknas från directional light (typ solen):

- light:dir_light_x
- light:dir_light_y
- light:dir_light_z 

En directional light har bara en konstant riktning, inte en riktning och en position som pointlights.

Justera styrka på skuggor från postprocess:shadow_att

### SSR
SRR slås på genom att sätta postprocess:ssr_type till 0, -1 för av.

Alla värden ovan kan justeras i design mode, Main window > Sync and design och sedan via reglage under Postprocess fönstret vilket är bra om man vill experimentera med värden.

## Raymarch

Det finns lite olika raymarchers som kan mergas in i en scen. Dessa kontrolleras via rm-gruppen i Bazooka och "Raymarch" fönstret i UI:t.

Varje marcher har en massa individuella värden, rm_param1-8 samt position, ljus med mera.
För att slå av raymarch sätt rm:effect till 0, för att slå på en effekt sätt den till ett värde:

- 1: Icoshedron lazers
- 2: Gyro
- 7: Spiral ribbons
- 9: Menger

